using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Widget;
using Api.Core;
using Newtonsoft.Json;

namespace GameReleases.Activities
{
    [Activity(Label = "GameDetailsActivity")]
    public class GameDetailsActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.game_click);

            var gameDetails = JsonConvert.DeserializeObject<Game>(Intent.GetStringExtra("gameDetails"));

            FindViewById<TextView>(Resource.Id.summary).Text = gameDetails.Summary;
        }
    }
}