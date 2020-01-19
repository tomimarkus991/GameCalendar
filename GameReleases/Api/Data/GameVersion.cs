using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class GameVersion : Game
    {
        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("features")]
        public Feature[] Features { get; set; }
    }

    public class Feature
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("values")]
        public ValueElement[] Values { get; set; }
    }

    public class ValueElement
    {
        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}