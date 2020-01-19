using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class Pulse : Game
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("pulse_source")]
        public long PulseSource { get; set; }

        [JsonProperty("published_at")]
        public long PublishedAt { get; set; }

        [JsonProperty("ignored")]
        public bool Ignored { get; set; }

        [JsonProperty("pulse_image")]
        public PulseImage PulseImage { get; set; }
    }

    public class PulseImage
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("cloudinary_id")]
        public string CloudinaryId { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }
    }
}
