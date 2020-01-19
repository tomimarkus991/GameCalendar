using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class Keyword : Game
    {
        [JsonProperty("multiplayer_modes")]
        public MultiplayerMode[] MultiplayerModes { get; set; }
    }

    public class MultiplayerMode
    {
        [JsonProperty("platform")]
        public long Platform { get; set; }

        [JsonProperty("offlinecoop")]
        public bool Offlinecoop { get; set; }

        [JsonProperty("onlinecoop")]
        public bool Onlinecoop { get; set; }

        [JsonProperty("lancoop")]
        public bool Lancoop { get; set; }

        [JsonProperty("campaigncoop")]
        public bool Campaigncoop { get; set; }

        [JsonProperty("splitscreenonline")]
        public bool Splitscreenonline { get; set; }

        [JsonProperty("splitscreen")]
        public bool Splitscreen { get; set; }

        [JsonProperty("dropin")]
        public bool Dropin { get; set; }

        [JsonProperty("offlinecoopmax")]
        public long Offlinecoopmax { get; set; }

        [JsonProperty("onlinecoopmax")]
        public long Onlinecoopmax { get; set; }

        [JsonProperty("onlinemax")]
        public long Onlinemax { get; set; }

        [JsonProperty("offlinemax")]
        public long Offlinemax { get; set; }
    }
}