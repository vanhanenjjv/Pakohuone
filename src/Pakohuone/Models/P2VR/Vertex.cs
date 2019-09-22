using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "vertex")]
    public class Vertex
    {
        [XmlAttribute(AttributeName = "pan")]
        public string Pan { get; set; }
        [XmlAttribute(AttributeName = "tilt")]
        public string Tilt { get; set; }
    }
}
