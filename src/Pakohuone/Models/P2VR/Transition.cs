using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "transition")]
    public class Transition
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "softedge")]
        public string Softedge { get; set; }
        [XmlAttribute(AttributeName = "zoomspeed")]
        public string Zoomspeed { get; set; }
        [XmlAttribute(AttributeName = "zoomoutpause")]
        public string Zoomoutpause { get; set; }
        [XmlAttribute(AttributeName = "blendcolor")]
        public string Blendcolor { get; set; }
        [XmlAttribute(AttributeName = "blendtime")]
        public string Blendtime { get; set; }
        [XmlAttribute(AttributeName = "zoomin")]
        public string Zoomin { get; set; }
        [XmlAttribute(AttributeName = "zoomfov")]
        public string Zoomfov { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "zoomout")]
        public string Zoomout { get; set; }
    }
}
