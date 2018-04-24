using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XMap.Models.Cadastral
{
    [XmlRoot(ElementName = "control", Namespace = "http://www.catastro.meh.es/")]
    public class Control
    {
        [XmlElement(ElementName = "cucoor", Namespace = "http://www.catastro.meh.es/")]
        public string Cucoor { get; set; }
        [XmlElement(ElementName = "cuerr", Namespace = "http://www.catastro.meh.es/")]
        public string Cuerr { get; set; }
    }

    [XmlRoot(ElementName = "geo", Namespace = "http://www.catastro.meh.es/")]
    public class Geo
    {
        [XmlElement(ElementName = "xcen", Namespace = "http://www.catastro.meh.es/")]
        public string Xcen { get; set; }
        [XmlElement(ElementName = "ycen", Namespace = "http://www.catastro.meh.es/")]
        public string Ycen { get; set; }
        [XmlElement(ElementName = "srs", Namespace = "http://www.catastro.meh.es/")]
        public string Srs { get; set; }
    }

    [XmlRoot(ElementName = "pc", Namespace = "http://www.catastro.meh.es/")]
    public class Pc
    {
        [XmlElement(ElementName = "pc1", Namespace = "http://www.catastro.meh.es/")]
        public string Pc1 { get; set; }
        [XmlElement(ElementName = "pc2", Namespace = "http://www.catastro.meh.es/")]
        public string Pc2 { get; set; }
    }

    [XmlRoot(ElementName = "loine", Namespace = "http://www.catastro.meh.es/")]
    public class Loine
    {
        [XmlElement(ElementName = "cp", Namespace = "http://www.catastro.meh.es/")]
        public string Cp { get; set; }
        [XmlElement(ElementName = "cm", Namespace = "http://www.catastro.meh.es/")]
        public string Cm { get; set; }
    }

    [XmlRoot(ElementName = "dir", Namespace = "http://www.catastro.meh.es/")]
    public class Dir
    {
        [XmlElement(ElementName = "cv", Namespace = "http://www.catastro.meh.es/")]
        public string Cv { get; set; }
        [XmlElement(ElementName = "pnp", Namespace = "http://www.catastro.meh.es/")]
        public string Pnp { get; set; }
        [XmlElement(ElementName = "plp", Namespace = "http://www.catastro.meh.es/")]
        public string Plp { get; set; }
    }

    [XmlRoot(ElementName = "lourb", Namespace = "http://www.catastro.meh.es/")]
    public class Lourb
    {
        [XmlElement(ElementName = "dir", Namespace = "http://www.catastro.meh.es/")]
        public Dir Dir { get; set; }
    }

    [XmlRoot(ElementName = "dt", Namespace = "http://www.catastro.meh.es/")]
    public class Dt
    {
        [XmlElement(ElementName = "loine", Namespace = "http://www.catastro.meh.es/")]
        public Loine Loine { get; set; }
        [XmlElement(ElementName = "lourb", Namespace = "http://www.catastro.meh.es/")]
        public Lourb Lourb { get; set; }
    }

    [XmlRoot(ElementName = "pcd", Namespace = "http://www.catastro.meh.es/")]
    public class Pcd
    {
        [XmlElement(ElementName = "pc", Namespace = "http://www.catastro.meh.es/")]
        public Pc Pc { get; set; }
        [XmlElement(ElementName = "dt", Namespace = "http://www.catastro.meh.es/")]
        public Dt Dt { get; set; }
        [XmlElement(ElementName = "ldt", Namespace = "http://www.catastro.meh.es/")]
        public string Ldt { get; set; }
        [XmlElement(ElementName = "dis", Namespace = "http://www.catastro.meh.es/")]
        public string Dis { get; set; }
    }

    [XmlRoot(ElementName = "lpcd", Namespace = "http://www.catastro.meh.es/")]
    public class Lpcd
    {
        [XmlElement(ElementName = "pcd", Namespace = "http://www.catastro.meh.es/")]
        public List<Pcd> Pcd { get; set; }
    }

    [XmlRoot(ElementName = "coordd", Namespace = "http://www.catastro.meh.es/")]
    public class Coordd
    {
        [XmlElement(ElementName = "geo", Namespace = "http://www.catastro.meh.es/")]
        public Geo Geo { get; set; }
        [XmlElement(ElementName = "lpcd", Namespace = "http://www.catastro.meh.es/")]
        public Lpcd Lpcd { get; set; }
    }

    [XmlRoot(ElementName = "coordenadas_distancias", Namespace = "http://www.catastro.meh.es/")]
    public class Coordenadas_distancias
    {
        [XmlElement(ElementName = "coordd", Namespace = "http://www.catastro.meh.es/")]
        public Coordd Coordd { get; set; }
    }

    [XmlRoot(ElementName = "consulta_coordenadas_distancias", Namespace = "http://www.catastro.meh.es/")]
    public class Consulta_coordenadas_distancias
    {
        [XmlElement(ElementName = "control", Namespace = "http://www.catastro.meh.es/")]
        public Control Control { get; set; }
        [XmlElement(ElementName = "coordenadas_distancias", Namespace = "http://www.catastro.meh.es/")]
        public Coordenadas_distancias Coordenadas_distancias { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }


    [XmlRoot(ElementName = "prov", Namespace = "http://www.catastro.meh.es/")]
    public class Prov
    {
        [XmlElement(ElementName = "cpine", Namespace = "http://www.catastro.meh.es/")]
        public string Cpine { get; set; }
        [XmlElement(ElementName = "np", Namespace = "http://www.catastro.meh.es/")]
        public string Np { get; set; }
    }

    [XmlRoot(ElementName = "provinciero", Namespace = "http://www.catastro.meh.es/")]
    public class Provinciero
    {
        [XmlElement(ElementName = "prov", Namespace = "http://www.catastro.meh.es/")]
        public List<Prov> Prov { get; set; }
    }

    [XmlRoot(ElementName = "consulta_provinciero", Namespace = "http://www.catastro.meh.es/")]
    public class ProvincesResponse
    {
        [XmlElement(ElementName = "control", Namespace = "http://www.catastro.meh.es/")]
        public Control Control { get; set; }
        [XmlElement(ElementName = "provinciero", Namespace = "http://www.catastro.meh.es/")]
        public Provinciero Provinciero { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }


    [XmlRoot(ElementName = "locat", Namespace = "http://www.catastro.meh.es/")]
    public class Locat
    {
        [XmlElement(ElementName = "cd", Namespace = "http://www.catastro.meh.es/")]
        public string Cd { get; set; }
        [XmlElement(ElementName = "cmc", Namespace = "http://www.catastro.meh.es/")]
        public string Cmc { get; set; }
    }

    [XmlRoot(ElementName = "muni", Namespace = "http://www.catastro.meh.es/")]
    public class Muni
    {
        [XmlElement(ElementName = "nm", Namespace = "http://www.catastro.meh.es/")]
        public string Nm { get; set; }
        [XmlElement(ElementName = "locat", Namespace = "http://www.catastro.meh.es/")]
        public Locat Locat { get; set; }
        [XmlElement(ElementName = "loine", Namespace = "http://www.catastro.meh.es/")]
        public Loine Loine { get; set; }
    }

    [XmlRoot(ElementName = "municipiero", Namespace = "http://www.catastro.meh.es/")]
    public class Municipiero
    {
        [XmlElement(ElementName = "muni", Namespace = "http://www.catastro.meh.es/")]
        public Muni Muni { get; set; }
    }

    [XmlRoot(ElementName = "consulta_municipiero", Namespace = "http://www.catastro.meh.es/")]
    public class Consulta_municipiero
    {
        [XmlElement(ElementName = "control", Namespace = "http://www.catastro.meh.es/")]
        public Control Control { get; set; }
        [XmlElement(ElementName = "municipiero", Namespace = "http://www.catastro.meh.es/")]
        public Municipiero Municipiero { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
