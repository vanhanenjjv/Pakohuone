using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "max")]
    public class Max
    {
        [XmlAttribute(AttributeName = "fovstereographic")]
        public string Fovstereographic { get; set; }
        [XmlAttribute(AttributeName = "fov")]
        public string Fov { get; set; }
        [XmlAttribute(AttributeName = "scaletofit")]
        public string Scaletofit { get; set; }
        [XmlAttribute(AttributeName = "fovfisheye")]
        public string Fovfisheye { get; set; }
        [XmlAttribute(AttributeName = "pan")]
        public string Pan { get; set; }
        [XmlAttribute(AttributeName = "tilt")]
        public string Tilt { get; set; }
    }
}
