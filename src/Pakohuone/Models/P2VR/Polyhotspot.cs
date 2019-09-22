using System.Xml.Serialization;
using System.Collections.Generic;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "polyhotspot")]
    public class Polyhotspot
    {
        [XmlElement(ElementName = "vertex")]
        public List<Vertex> Vertex { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "target")]
        public string Target { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
    }
}
