using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class PlayTime : Game
    {
        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("user")]
        public long User { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }
}
