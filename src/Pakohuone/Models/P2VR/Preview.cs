using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "preview")]
    public class Preview
    {
        [XmlAttribute(AttributeName = "strip")]
        public string Strip { get; set; }
        [XmlAttribute(AttributeName = "color")]
        public string Color { get; set; }
    }
}
