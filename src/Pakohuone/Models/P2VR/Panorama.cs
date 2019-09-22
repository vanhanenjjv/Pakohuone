using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "panorama")]
    public class Panorama
    {
        [XmlElement(ElementName = "input")]
        public Input Input { get; set; }
        [XmlElement(ElementName = "view")]
        public View View { get; set; }
        [XmlElement(ElementName = "userdata")]
        public Userdata Userdata { get; set; }
        [XmlElement(ElementName = "hotspots")]
        public Hotspots Hotspots { get; set; }
        [XmlElement(ElementName = "transition")]
        public Transition Transition { get; set; }
        [XmlElement(ElementName = "animation")]
        public Animation Animation { get; set; }
        [XmlElement(ElementName = "control")]
        public Control Control { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "media")]
        public Media Media { get; set; }
    }
}
