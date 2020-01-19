using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class Page : Game
    {
        [JsonProperty("page_follows_count")]
        public long PageFollowsCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("youtube")]
        public string Youtube { get; set; }

        [JsonProperty("logo")]
        public Background Logo { get; set; }

        [JsonProperty("background")]
        public Background Background { get; set; }
    }

    public class Background
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
        