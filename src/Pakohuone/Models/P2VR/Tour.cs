using System.Collections.Generic;
using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "tour")]
    public class Tour
    {
        [XmlElement(ElementName = "panorama")]
        public List<Panorama> Panorama { get; set; }

        [XmlAttribute(AttributeName = "apprev")]
        public string AppRev { get; set; }

        [XmlAttribute(AttributeName = "appversion")]
        public string AppVersion { get; set; }

        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }
    }
}
