using System.Xml.Serialization;
using System.Collections.Generic;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "input")]
    public class Input
    {
        [XmlElement(ElementName = "level")]
        public List<Level> Level { get; set; }
        [XmlElement(ElementName = "preview")]
        public Preview Preview { get; set; }
        [XmlAttribute(AttributeName = "levelbiashidpi")]
        public string Levelbiashidpi { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "overlap")]
        public string Overlap { get; set; }
        [XmlAttribute(AttributeName = "levelbias")]
        public string Levelbias { get; set; }
        [XmlAttribute(AttributeName = "levelingroll")]
        public string Levelingroll { get; set; }
        [XmlAttribute(AttributeName = "leveltileurl")]
        public string Leveltileurl { get; set; }
        [XmlAttribute(AttributeName = "levelingpitch")]
        public string Levelingpitch { get; set; }
        [XmlAttribute(AttributeName = "leveltilesize")]
        public string Leveltilesize { get; set; }
    }
}
