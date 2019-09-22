using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "view")]
    public class View
    {
        [XmlElement(ElementName = "start")]
        public Start Start { get; set; }
        [XmlElement(ElementName = "flyin")]
        public Flyin Flyin { get; set; }
        [XmlElement(ElementName = "min")]
        public Min Min { get; set; }
        [XmlElement(ElementName = "max")]
        public Max Max { get; set; }
        [XmlAttribute(AttributeName = "pannorth")]
        public string Pannorth { get; set; }
        [XmlAttribute(AttributeName = "fovmode")]
        public string Fovmode { get; set; }
    }
}
