using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "control")]
    public class Control
    {
        [XmlAttribute(AttributeName = "simulatemass")]
        public string Simulatemass { get; set; }
        [XmlAttribute(AttributeName = "lockedkeyboard")]
        public string Lockedkeyboard { get; set; }
        [XmlAttribute(AttributeName = "dblclickfullscreen")]
        public string Dblclickfullscreen { get; set; }
        [XmlAttribute(AttributeName = "hideabout")]
        public string Hideabout { get; set; }
        [XmlAttribute(AttributeName = "invertwheel")]
        public string Invertwheel { get; set; }
        [XmlAttribute(AttributeName = "invertcontrol")]
        public string Invertcontrol { get; set; }
        [XmlAttribute(AttributeName = "lockedkeyboardzoom")]
        public string Lockedkeyboardzoom { get; set; }
        [XmlAttribute(AttributeName = "lockedwheel")]
        public string Lockedwheel { get; set; }
        [XmlAttribute(AttributeName = "contextfullscreen")]
        public string Contextfullscreen { get; set; }
        [XmlAttribute(AttributeName = "lockedmouse")]
        public string Lockedmouse { get; set; }
        [XmlAttribute(AttributeName = "contextprojections")]
        public string Contextprojections { get; set; }
        [XmlAttribute(AttributeName = "rubberband")]
        public string Rubberband { get; set; }
        [XmlAttribute(AttributeName = "sensitivity")]
        public string Sensitivity { get; set; }
        [XmlAttribute(AttributeName = "speedwheel")]
        public string Speedwheel { get; set; }
    }
}

