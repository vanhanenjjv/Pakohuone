using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "level")]
    public class Level
    {
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "predecode")]
        public string Predecode { get; set; }
        [XmlAttribute(AttributeName = "preload")]
        public string Preload { get; set; }
    }
}
