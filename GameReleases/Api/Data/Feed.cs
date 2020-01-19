using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Core
{
    public class Feed : Game
    {
        [JsonProperty("pulse")]
        public long Pulse { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }
    }
}
