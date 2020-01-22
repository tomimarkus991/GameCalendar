using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Widget;
using Api.Core;
using FFImageLoading;
using Newtonsoft.Json;
using System;

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

            FindViewById<TextView>(Resource.Id.name).Text = gameDetails.Name;
            //FindViewById<TextView>(Resource.Id.company).Text = gameDetails.Company[0].Name;
            if (gameDetails.Genres == null)
            {
                FindViewById<TextView>(Resource.Id.pointAndClick).Text = "";
            }
            else
            {
                foreach (var genre in gameDetails.Genres)
                {
                    if (genre.Id == 2)
                    {
                        FindViewById<TextView>(Resource.Id.pointAndClick).Text = "Point and click  ";
                    }
                    else if (genre.Id == 4)
                    {
                        FindViewById<TextView>(Resource.Id.fighting).Text = "Fighting  ";
                    }
                    else if (genre.Id == 5)
                    {
                        FindViewById<TextView>(Resource.Id.shooter).Text = "Shooter  ";
                    }
                    else if (genre.Id == 7)
                    {
                        FindViewById<TextView>(Resource.Id.music).Text = "Music  ";
                    }
                    else if (genre.Id == 8)
                    {
                        FindViewById<TextView>(Resource.Id.platform).Text = "Platform  ";
                    }
                    else if (genre.Id == 9)
                    {
                        FindViewById<TextView>(Resource.Id.puzzle).Text = "Puzzle  ";
                    }
                    else if (genre.Id == 10)
                    {
                        FindViewById<TextView>(Resource.Id.racing).Text = "Racing  ";
                    }
                    else if (genre.Id == 11)
                    {
                        FindViewById<TextView>(Resource.Id.rts).Text = "Real Time Strategy  ";
                    }
                    else if (genre.Id == 12)
                    {
                        FindViewById<TextView>(Resource.Id.rpg).Text = "Role-playing  ";
                    }
                    else if (genre.Id == 13)
                    {
                        FindViewById<TextView>(Resource.Id.simulator).Text = "Simulator  ";
                    }
                    else if (genre.Id == 14)
                    {
                        FindViewById<TextView>(Resource.Id.sport).Text = "Sport  ";
                    }
                    else if (genre.Id == 15)
                    {
                        FindViewById<TextView>(Resource.Id.strategy).Text = "Strategy  ";
                    }
                    else if (genre.Id == 16)
                    {
                        FindViewById<TextView>(Resource.Id.tbs).Text = "Turn-based strategy  ";
                    }
                    else if (genre.Id == 24)
                    {
                        FindViewById<TextView>(Resource.Id.tactical).Text = "Tactical  ";
                    }
                    else if (genre.Id == 26)
                    {
                        FindViewById<TextView>(Resource.Id.quizTrivia).Text = "Quiz/Trivia  ";
                    }
                    else if (genre.Id == 30)
                    {
                        FindViewById<TextView>(Resource.Id.pinball).Text = "Pinball  ";
                    }
                    else if (genre.Id == 31)
                    {
                        FindViewById<TextView>(Resource.Id.adventure).Text = "Adventure ";
                    }
                    else if (genre.Id == 32)
                    {
                        FindViewById<TextView>(Resource.Id.indie).Text = "Indie  ";
                    }
                    else if (genre.Id == 33)
                    {
                        FindViewById<TextView>(Resource.Id.arcade).Text = "Arcade  ";
                    }
                    else if (genre.Id == 34)
                    {
                        FindViewById<TextView>(Resource.Id.visualNovel).Text = "Visual Novel";
                    }
                }
            }
            if (gameDetails.Cover == null)
            {
                FindViewById<ImageView>(Resource.Id.gameCover).SetImageResource(Resource.Drawable.no_picture2);
            }
            else
            {
                string apiBaseURL = "https:" + gameDetails.Cover.Url;
                var imageView = FindViewById<ImageView>(Resource.Id.gameCover);

                string coverBig = apiBaseURL.Replace("/t_thumb/", "/t_cover_big/");

                ImageService.Instance.LoadUrl(coverBig).Into(imageView);
            }
            FindViewById<TextView>(Resource.Id.summary).Text = gameDetails.Summary;
            var backButton = FindViewById<Button>(Resource.Id.button1);
            //backButton.Click += BackButton_Click;

        }
        //private void BackButton_Click(object sender, EventArgs e)
        //{
        //    //var intent = new Intent(this, typeof(SearchActivity));
        //    this.OnBackPressed();
        //}
    }
}