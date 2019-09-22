using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Serialization;
using Pakohuone.Data;
using Pakohuone.Entities;
using Pakohuone.Extensions;
using Pakohuone.Models;
using P2VR = Pakohuone.Models.Pano2VR;

namespace Pakohuone.Services
{
    public class WorldService
    {
        private readonly DirectoryInfo tempDirectory;
        private readonly DirectoryInfo worldsDirectory;
        private readonly PakohuoneContext context;

        public WorldService(PakohuoneConfiguration configuration, PakohuoneContext context)
        {
            this.tempDirectory = Directory.CreateDirectory(configuration.Path.TemporaryDirectory);
            this.worldsDirectory = Directory.CreateDirectory(
                Path.Combine(configuration.Path.ContentDirectory, "Worlds"));
            this.context = context;
        }

        private bool TryExtractWorld(Stream stream, out DirectoryInfo worldDirectory)
        {
            worldDirectory = null;
            bool success = false;

            string name = DateTime.UtcNow.Ticks.ToString();

            var workDir = Directory.CreateDirectory(
                Path.Combine(tempDirectory.FullName, name));

            string outputZip = Path.Combine(workDir.FullName, "output.zip");
            using (var output = File.Open(outputZip, FileMode.Create))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(output);
            }

            ZipFile.ExtractToDirectory(outputZip, workDir.FullName);

            var outputDir = new DirectoryInfo(
                Path.Combine(workDir.FullName, "output"));
            var panoXmlFile = new FileInfo(
                Path.Combine(outputDir.FullName, "pano.xml"));

            if (outputDir.Exists && panoXmlFile.Exists)
            {
                worldDirectory = new DirectoryInfo(
                    Path.Combine(this.worldsDirectory.FullName, name));

                Directory.Move(outputDir.FullName, worldDirectory.FullName);

                success = true;
            }

            workDir.Delete(true);

            return success;
        }

        public bool TryAddWorld(Stream stream, out World world)
        {
            world = null;

            if (TryExtractWorld(stream, out DirectoryInfo worldDirectory))
            {
                string panoXmlFileName = Path.Combine(worldDirectory.FullName, "pano.xml");
                var tourSerializer = new XmlSerializer(typeof(P2VR.Tour));

                using (var panoXmlFileStream = File.Open(panoXmlFileName, FileMode.Open))
                {
                    var tour = tourSerializer.Deserialize(panoXmlFileStream) as P2VR.Tour;

                    world = new World
                    {
                        Directory = worldDirectory.Name
                    };

                    this.context.Add(world);

                    foreach (var name in tour.GetRoomNames())
                        this.context.Add(new Room { Name = name, World = world });

                    this.context.SaveChanges();

                    return true;
                }
            }

            return false;
        }
    }
}
