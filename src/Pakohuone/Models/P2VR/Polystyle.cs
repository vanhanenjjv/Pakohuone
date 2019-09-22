using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "polystyle")]
    public class Polystyle
    {
        [XmlAttribute(AttributeName = "backgroundcolor")]
        public string Backgroundcolor { get; set; }
        [XmlAttribute(AttributeName = "borderalpha")]
        public string Borderalpha { get; set; }
        [XmlAttribute(AttributeName = "bordercolor")]
        public string Bordercolor { get; set; }
        [XmlAttribute(AttributeName = "mode")]
        public string Mode { get; set; }
        [XmlAttribute(AttributeName = "backgroundalpha")]
        public string Backgroundalpha { get; set; }
        [XmlAttribute(AttributeName = "handcursor")]
        public string Handcursor { get; set; }
    }
}
