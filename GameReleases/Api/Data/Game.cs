using Api.Core.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.Core
{
    public class Game
    {      
        public List<Game> Game_data { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("storyline")]
        public string Storyline { get; set; }

        [JsonProperty("collection")]
        public long Collection { get; set; }

        [JsonProperty("franchise")]
        public long Franchise { get; set; }

        [JsonProperty("franchises")]
        public List<long> Franchises { get; set; }

        [JsonProperty("hypes")]
        public long Hypes { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("aggregated_rating")]
        public double AggregatedRating { get; set; }

        [JsonProperty("aggregated_rating_count")]
        public long AggregatedRatingCount { get; set; }

        [JsonProperty("total_rating")]
        public double TotalRating { get; set; }

        [JsonProperty("total_rating_count")]
        public long TotalRatingCount { get; set; }

        [JsonProperty("rating_count")]
        public long RatingCount { get; set; }

        [JsonProperty("games")]
        public List<long> Games { get; set; }

        [JsonProperty("tags")]
        public List<long> Tags { get; set; }

        [JsonProperty("developers")]
        public List<long> Developers { get; set; }

        [JsonProperty("publishers")]
        public List<long> Publishers { get; set; }

        [JsonProperty("game_engines")]
        public List<long> GameEngines { get; set; }

        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("time_to_beat")]
        public TimeToBeat TimeToBeat { get; set; }

        [JsonProperty("player_perspectives")]
        public List<long> PlayerPerspectives { get; set; }

        [JsonProperty("game_modes")]
        public List<long> GameModes { get; set; }

        [JsonProperty("keywords")]
        public List<long> Keywords { get; set; }

        [JsonProperty("themes")]
        public List<long>Themes { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("expansions")]
        public List<long> Expansions { get; set; }

        [JsonProperty("first_release_date")]
        public long FirstReleaseDate { get; set; }

        [JsonProperty("pulse_count")]
        public long PulseCount { get; set; }
        public List<Company> Company { get; set; }

        [JsonProperty("platforms")]
        public List<Platform> Platforms { get; set; }

        [JsonProperty("release_dates")]
        public List<ReleaseDate> ReleaseDates { get; set; }

        [JsonProperty("alternative_names")]
        public List<AlternativeName> AlternativeNames { get; set; }

        [JsonProperty("screenshots")]
        public List<Cover> Screenshots { get; set; }

        [JsonProperty("videos")]
        public List<Video> Videos { get; set; }

        [JsonProperty("cover")]
        public Cover Cover { get; set; }

        [JsonProperty("esrb")]
        public Esrb Esrb { get; set; }

        [JsonProperty("pegi")]
        public Esrb Pegi { get; set; }

        [JsonProperty("websites")]
        public List<Website> Websites { get; set; }

        [JsonProperty("external")]
        public External External { get; set; }
    }
    public class ReleaseDate
    {
        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("platform")]
        public long Platform { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("human")]
        public string Human { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("m")]
        public long M { get; set; }
    }

    public class Website
    {
        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Video
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("video_id")]
        public string VideoId { get; set; }
    }

    public class TimeToBeat
    {
        [JsonProperty("hastly")]
        public long Hastly { get; set; }

        [JsonProperty("normally")]
        public long Normally { get; set; }

        [JsonProperty("completely")]
        public long Completely { get; set; }
    }

    public partial class External
    {
        [JsonProperty("steam")]
        public string Steam { get; set; }
    }

    public partial class Esrb
    {
        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }
    }

    public partial class Cover
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

    public class AlternativeName
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
