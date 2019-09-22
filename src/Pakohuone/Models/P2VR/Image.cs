using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "image")]
    public class Image
    {
        [XmlElement(ElementName = "source")]
        public Source Source { get; set; }
        [XmlAttribute(AttributeName = "stretch")]
        public string Stretch { get; set; }
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "rotz")]
        public string Rotz { get; set; }
        [XmlAttribute(AttributeName = "fov")]
        public string Fov { get; set; }
        [XmlAttribute(AttributeName = "roty")]
        public string Roty { get; set; }
        [XmlAttribute(AttributeName = "rotx")]
        public string Rotx { get; set; }
        [XmlAttribute(AttributeName = "clickmode")]
        public string Clickmode { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "pan")]
        public string Pan { get; set; }
        [XmlAttribute(AttributeName = "tilt")]
        public string Tilt { get; set; }
        [XmlAttribute(AttributeName = "handcursor")]
        public string Handcursor { get; set; }
    }
}

