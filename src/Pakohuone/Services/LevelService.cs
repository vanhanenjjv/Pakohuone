using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Pakohuone.Data;
using Pakohuone.Entities;
using Pakohuone.Models;

namespace Pakohuone.Services
{
    public class LevelService
    {
        private readonly DirectoryInfo tempDirectory;
        private readonly DirectoryInfo levelsDirectory;
        private readonly PakohuoneContext context;

        public LevelService(PakohuoneConfiguration configuration, PakohuoneContext context)
        {
            this.tempDirectory = Directory.CreateDirectory(configuration.Path.TemporaryDirectory);
            this.levelsDirectory = Directory.CreateDirectory(
                Path.Combine(configuration.Path.ContentDirectory, "Levels"));
            this.context = context;
        }

        public bool TryExtractLevel(Stream stream, out DirectoryInfo levelDirectory)
        {
            levelDirectory = null;
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

            var workDirContents = workDir.EnumerateFileSystemInfos();
            var outputDir = workDirContents.FirstOrDefault(f =>
                f.Attributes.HasFlag(FileAttributes.Directory));

            if (workDirContents.Count() == 2 &&
                outputDir != null)
            {
                var indexPage = new FileInfo(Path.Combine(outputDir.FullName, "index.html"));
                var c2Runtime = new FileInfo(Path.Combine(outputDir.FullName, "c2runtime.js"));

                if (indexPage.Exists && c2Runtime.Exists)
                {
                    levelDirectory = new DirectoryInfo(
                        Path.Combine(levelsDirectory.FullName, name));

                    Directory.Move(outputDir.FullName, levelDirectory.FullName);

                    success = true;
                }
            }

            workDir.Delete(true);

            return success;
        }

        public bool TryAddLevel(Stream stream, out Level level)
        {
            level = null;

            if (TryExtractLevel(stream, out DirectoryInfo levelDirectory))
            {
                level = new Level
                {
                    Directory = levelDirectory.Name
                };

                this.context.Add(level);
                this.context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
