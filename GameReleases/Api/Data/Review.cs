using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api.Core
{
    public class Review : Game
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("review_rating")]
        public long ReviewRating { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("game")]
        public long Game { get; set; }

        [JsonProperty("likes")]
        public long Likes { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("rating_category")]
        public long RatingCategory { get; set; }

        [JsonProperty("platform")]
        public long Platform { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}