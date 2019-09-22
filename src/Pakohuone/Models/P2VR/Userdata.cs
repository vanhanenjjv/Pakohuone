using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "userdata")]
    public class Userdata
    {
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "latitude")]
        public string Latitude { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }
        [XmlAttribute(AttributeName = "comment")]
        public string Comment { get; set; }
        [XmlAttribute(AttributeName = "longitude")]
        public string Longitude { get; set; }
        [XmlAttribute(AttributeName = "datetime")]
        public string Datetime { get; set; }
        [XmlAttribute(AttributeName = "customnodeid")]
        public string Customnodeid { get; set; }
        [XmlAttribute(AttributeName = "source")]
        public string Source { get; set; }
        [XmlAttribute(AttributeName = "copyright")]
        public string Copyright { get; set; }
        [XmlAttribute(AttributeName = "tags")]
        public string Tags { get; set; }
        [XmlAttribute(AttributeName = "author")]
        public string Author { get; set; }
    }
}
