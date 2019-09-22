using Newtonsoft.Json;

namespace Pakohuone.Models
{
    public class PakohuoneConfiguration
    {
        [JsonRequired]
        public PakohuoneConfigurationPath Path { get; set; }

        public class PakohuoneConfigurationPath
        {
            [JsonRequired]
            public string TemporaryDirectory { get; set; }

            [JsonRequired]
            public string ContentDirectory { get; set; }
        }
    }
}
