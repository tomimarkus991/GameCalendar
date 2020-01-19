using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Core
{
    public class Character : Game
    {
        [JsonProperty("people")]
        public List<long> People { get; set; }
    }
}
