using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "source")]
    public class Source
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
    }
}
