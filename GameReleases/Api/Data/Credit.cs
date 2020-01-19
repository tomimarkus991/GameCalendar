using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Core
{
    public class Credit : Game
    {
        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("person")]
        public long Person { get; set; }

        [JsonProperty("character")]
        public long Character { get; set; }
    }
}
