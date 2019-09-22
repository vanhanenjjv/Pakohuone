using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "animation")]
    public class Animation
    {
        [XmlAttribute(AttributeName = "useinautorotation")]
        public string Useinautorotation { get; set; }
        [XmlAttribute(AttributeName = "syncanimationwithvideo")]
        public string Syncanimationwithvideo { get; set; }
    }
}

