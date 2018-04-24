using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMap.Services
{
    using Models.Cadastral;
    using Catastro;
    using System.ServiceModel;

    public class CadastralService : ICadastralService
    {
        private const string URL = "https://ovc.catastro.meh.es/";
        private const string PROVINCES_ENDPOINT = "ovcservweb/ovcswlocalizacionrc/ovccallejerocodigos.asmx/ConsultaProvincia";
        private const string COUNCILS_ENDPOINT = "ovcservweb/ovcswlocalizacionrc/ovccallejerocodigos.asmx/ConsultaMunicipioCodigos?CodigoProvincia={0}&CodigoMunicipioIne={1}&CodigoMunicipio=";
        private const string RC_ENDPOINT = "ovcservweb/ovcswlocalizacionrc/ovccoordenadas.asmx/Consulta_RCCOOR_Distancia?SRS={0}&Coordenada_X={1}&Coordenada_Y={2}";
        // private const string INFO_ENDPOINT = "ovcservweb/ovcswlocalizacionrc/ovccallejerocodigos.asmx/Consulta_DNPRC_Codigos?CodigoProvincia={0}&CodigoMunicipio={1}&CodigoMunicipioINE={2}&RC={3}";
        private const string DEFAULT_SRS = "EPSG:4326";

        private ProvincesResponse _provinces;

        public CadastralService()
        {
        }

        public async Task<string> FindCadastralReference(
            double lat,
            double lon)
        {
            var latStr = lat.ToString(provider: CultureInfo.InvariantCulture);
            var lonStr = lon.ToString(provider: CultureInfo.InvariantCulture);
            var url = $"{URL}" + String.Format(RC_ENDPOINT, DEFAULT_SRS, lonStr, latStr);
            var res = await HttpGet<Consulta_coordenadas_distancias>(url);

            if (res.Coordenadas_distancias?.Coordd?.Lpcd?.Pcd?.FirstOrDefault() != null)
            {
                var firstOccurrence = res.Coordenadas_distancias.Coordd.Lpcd.Pcd.FirstOrDefault();

                var councilINECode = firstOccurrence.Dt.Loine.Cm;
                var provinceCode = firstOccurrence.Dt.Loine.Cp;

                var reference = firstOccurrence.Pc.Pc1 + firstOccurrence.Pc.Pc2;

                // get the council code
                var councilUrl = $"{URL}" + String.Format(COUNCILS_ENDPOINT, provinceCode, councilINECode);
                var councilRes = await HttpGet<Consulta_municipiero>(councilUrl);

                var councilCode = councilRes.Municipiero.Muni.Locat.Cmc;

                //var infoUrl = $"{URL}" + String.Format(INFO_ENDPOINT, provinceCode, councilCode, councilINECode, reference);
                //Console.WriteLine(infoUrl);
                //var httpClient = new HttpClient();
                //var infoRes = await httpClient.GetStringAsync(infoUrl);
                var client = new CallejerodelasedeelectrónicadelcatastroSoapClient(
                    new BasicHttpsBinding(BasicHttpsSecurityMode.Transport),
                    new EndpointAddress(URL + "ovcservweb/ovcswlocalizacionrc/ovccallejerocodigos.asmx"));
                var infoRes = await client.Consulta_DNPRCAsync(
                    new Consulta_DNPRCRequest
                    {
                        Provincia = provinceCode,
                        Municipio = councilCode,
                        RefCat = reference
                    });

                return infoRes.ToString();
            }
            else
            {
                return null;
            }
        }

        private async Task<ProvincesResponse> GetProvinces()
        {
            if (_provinces == null)
            {
                _provinces = await HttpGet<ProvincesResponse>($"{URL}{PROVINCES_ENDPOINT}");
            }

            return _provinces;
        }

        private async Task<T> HttpGet<T>(string url) where T: class
        {
            var httpClient = new HttpClient();
            using (var res = await httpClient.GetStreamAsync(url))
            {
                var serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(res) as T;
            }
        }
    }
}
