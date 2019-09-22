using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using P2VR = Pakohuone.Models.Pano2VR;

namespace Pakohuone.Extensions
{
    public static class TourExtensions
    {
        private const string StartLevelMethodCall = "javascript:startLevel";

        public static string[] GetRoomNames(this P2VR.Tour tour)
        {
            var roomNames = new HashSet<string>();

            foreach (var panorama in tour.Panorama)
            {
                foreach (var hotspot in panorama.Hotspots.Polyhotspot)
                {
                    if (hotspot.Target == "_self" && hotspot.Url.StartsWith(StartLevelMethodCall))
                    {
                        // I use magic to get the room name
                        var match = Regex.Match(hotspot.Url, @"\(\'(.*?)\'\)");

                        if (!match.Success)
                            throw new InvalidDataException(hotspot.Url);

                        string name = match.Value
                            .Remove(match.Value.Length - 2, 2)
                            .Remove(0, 2);

                        roomNames.Add(name);
                    }
                }
            }

            return roomNames.ToArray();
        }
    }
}
