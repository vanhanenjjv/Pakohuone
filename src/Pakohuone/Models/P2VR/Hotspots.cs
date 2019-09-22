using System.Xml.Serialization;
using System.Collections.Generic;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "hotspots")]
    public class Hotspots
    {
        [XmlElement(ElementName = "label")]
        public Label Label { get; set; }
        [XmlElement(ElementName = "polystyle")]
        public Polystyle Polystyle { get; set; }
        [XmlElement(ElementName = "hotspot")]
        public List<Hotspot> Hotspot { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "wordwrap")]
        public string Wordwrap { get; set; }
        [XmlElement(ElementName = "polyhotspot")]
        public List<Polyhotspot> Polyhotspot { get; set; }
    }
}
