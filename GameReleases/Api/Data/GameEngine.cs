using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class GameEngine : Game
    {
        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("companies")]
        public long[] Companies { get; set; }

    }

    public class Logo
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