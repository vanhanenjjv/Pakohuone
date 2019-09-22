using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "label")]
    public class Label
    {
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "backgroundcolor")]
        public string Backgroundcolor { get; set; }
        [XmlAttribute(AttributeName = "borderalpha")]
        public string Borderalpha { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "bordercolor")]
        public string Bordercolor { get; set; }
        [XmlAttribute(AttributeName = "textcolor")]
        public string Textcolor { get; set; }
        [XmlAttribute(AttributeName = "border")]
        public string Border { get; set; }
        [XmlAttribute(AttributeName = "borderradius")]
        public string Borderradius { get; set; }
        [XmlAttribute(AttributeName = "textalpha")]
        public string Textalpha { get; set; }
        [XmlAttribute(AttributeName = "backgroundalpha")]
        public string Backgroundalpha { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "wordwrap")]
        public string Wordwrap { get; set; }
        [XmlAttribute(AttributeName = "background")]
        public string Background { get; set; }
    }
}
