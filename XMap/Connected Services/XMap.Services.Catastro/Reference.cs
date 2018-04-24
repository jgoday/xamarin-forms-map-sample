//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace XMap.Services.Catastro
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="Callejero de la sede electrónica del catastro.Soap", Namespace="http://tempuri.org/OVCServWeb/OVCCallejero", ConfigurationName="XMap.Services.Catastro.CallejerodelasedeelectrónicadelcatastroSoap")]
    public interface CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPRC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPRCResponse> Consulta_DNPRCAsync(XMap.Services.Catastro.Consulta_DNPRCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaProvincia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaProvincia1> ObtenerProvinciasAsync(XMap.Services.Catastro.ConsultaProvincia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaMunicipio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaMunicipio1> ObtenerMunicipiosAsync(XMap.Services.Catastro.ConsultaMunicipio request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaVia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaVia1> ObtenerCallejeroAsync(XMap.Services.Catastro.ConsultaVia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaNumero", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaNumero1> ObtenerNumereroAsync(XMap.Services.Catastro.ConsultaNumero request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPLOC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(XMap.Services.Catastro.Consulta_DNPLOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPPP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPPPResponse> Consulta_DNPPPAsync(XMap.Services.Catastro.Consulta_DNPPPRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string RefCat;
        
        public Consulta_DNPRCRequest()
        {
        }
        
        public Consulta_DNPRCRequest(string Provincia, string Municipio, string RefCat)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.RefCat = RefCat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Consulta_DNP;
        
        public Consulta_DNPRCResponse()
        {
        }
        
        public Consulta_DNPRCResponse(System.Xml.Linq.XElement Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia
    {
        
        public ConsultaProvincia()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Provincias;
        
        public ConsultaProvincia1()
        {
        }
        
        public ConsultaProvincia1(System.Xml.Linq.XElement Provincias)
        {
            this.Provincias = Provincias;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        public ConsultaMunicipio()
        {
        }
        
        public ConsultaMunicipio(string Provincia, string Municipio)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Municipios;
        
        public ConsultaMunicipio1()
        {
        }
        
        public ConsultaMunicipio1(System.Xml.Linq.XElement Municipios)
        {
            this.Municipios = Municipios;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NombreVia;
        
        public ConsultaVia()
        {
        }
        
        public ConsultaVia(string Provincia, string Municipio, string TipoVia, string NombreVia)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NombreVia = NombreVia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Callejero;
        
        public ConsultaVia1()
        {
        }
        
        public ConsultaVia1(System.Xml.Linq.XElement Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NomVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        public ConsultaNumero()
        {
        }
        
        public ConsultaNumero(string Provincia, string Municipio, string TipoVia, string NomVia, string Numero)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NomVia = NomVia;
            this.Numero = Numero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Callejero;
        
        public ConsultaNumero1()
        {
        }
        
        public ConsultaNumero1(System.Xml.Linq.XElement Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Sigla;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Calle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=5)]
        public string Bloque;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=6)]
        public string Escalera;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=7)]
        public string Planta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=8)]
        public string Puerta;
        
        public Consulta_DNPLOCRequest()
        {
        }
        
        public Consulta_DNPLOCRequest(string Provincia, string Municipio, string Sigla, string Calle, string Numero, string Bloque, string Escalera, string Planta, string Puerta)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Sigla = Sigla;
            this.Calle = Calle;
            this.Numero = Numero;
            this.Bloque = Bloque;
            this.Escalera = Escalera;
            this.Planta = Planta;
            this.Puerta = Puerta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Consulta_DNP;
        
        public Consulta_DNPLOCResponse()
        {
        }
        
        public Consulta_DNPLOCResponse(System.Xml.Linq.XElement Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Poligono;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Parcela;
        
        public Consulta_DNPPPRequest()
        {
        }
        
        public Consulta_DNPPPRequest(string Provincia, string Municipio, string Poligono, string Parcela)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Poligono = Poligono;
            this.Parcela = Parcela;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.Linq.XElement Consulta_DNPPP;
        
        public Consulta_DNPPPResponse()
        {
        }
        
        public Consulta_DNPPPResponse(System.Xml.Linq.XElement Consulta_DNPPP)
        {
            this.Consulta_DNPPP = Consulta_DNPPP;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface CallejerodelasedeelectrónicadelcatastroSoapChannel : XMap.Services.Catastro.CallejerodelasedeelectrónicadelcatastroSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class CallejerodelasedeelectrónicadelcatastroSoapClient : System.ServiceModel.ClientBase<XMap.Services.Catastro.CallejerodelasedeelectrónicadelcatastroSoap>, XMap.Services.Catastro.CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPRCResponse> Consulta_DNPRCAsync(XMap.Services.Catastro.Consulta_DNPRCRequest request)
        {
            return base.Channel.Consulta_DNPRCAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaProvincia1> ObtenerProvinciasAsync(XMap.Services.Catastro.ConsultaProvincia request)
        {
            return base.Channel.ObtenerProvinciasAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaMunicipio1> ObtenerMunicipiosAsync(XMap.Services.Catastro.ConsultaMunicipio request)
        {
            return base.Channel.ObtenerMunicipiosAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaVia1> ObtenerCallejeroAsync(XMap.Services.Catastro.ConsultaVia request)
        {
            return base.Channel.ObtenerCallejeroAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.ConsultaNumero1> ObtenerNumereroAsync(XMap.Services.Catastro.ConsultaNumero request)
        {
            return base.Channel.ObtenerNumereroAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(XMap.Services.Catastro.Consulta_DNPLOCRequest request)
        {
            return base.Channel.Consulta_DNPLOCAsync(request);
        }
        
        public System.Threading.Tasks.Task<XMap.Services.Catastro.Consulta_DNPPPResponse> Consulta_DNPPPAsync(XMap.Services.Catastro.Consulta_DNPPPRequest request)
        {
            return base.Channel.Consulta_DNPPPAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
