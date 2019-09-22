using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "media")]
    public class Media
    {
        [XmlElement(ElementName = "image")]
        public Image Image { get; set; }
    }
}
