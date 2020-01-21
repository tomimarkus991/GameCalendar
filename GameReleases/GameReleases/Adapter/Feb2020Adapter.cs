using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Api.Core;
using FFImageLoading;
using GameReleases.Fragments;

namespace GameReleases.Adapter
{
    class Feb2020Adapter : BaseAdapter<Game>
    {
        private FebFragment febFragment;
        private List<Game> games;

        public Feb2020Adapter(FebFragment febFragment, List<Game> games)
        {
            this.febFragment = febFragment;
            this.games = games;
        }
        public override Game this[int position]
        {
            get { return games[position]; }
        }
        public override int Count
        {
            get { return games.Count; }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = games[position];
            View view = convertView;
                if (view == null)
                {
                    view = febFragment.LayoutInflater.Inflate(Resource.Layout.game_row, null);
                }

                view.FindViewById<TextView>(Resource.Id.name).Text = item.Name;

                view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                // Platform
                if (item.Platforms.Count == 0)
                {
                    view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                    view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                    view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                }
                else
                {
                    foreach (var platform in item.Platforms)
                    {
                        if (platform.Id == 3)
                        {
                            view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                        }
                        else if (platform.Id == 6 || platform.Id == 92)
                        {
                            view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                        }
                        else if (platform.Id == 14)
                        {
                            view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                        }
                        else if (platform.Id == 48)
                        {
                            view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                        }
                        else if (platform.Id == 49)
                        {
                            view.FindViewById<TextView>(Resource.Id.xboxO).Text = "XboxO ";
                        }
                        else if (platform.Id == 130)
                        {
                            view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                        }
                    }


                }

                // Time
                string unixtime = item.FirstReleaseDate.ToString();
                view.FindViewById<TextView>(Resource.Id.releaseDate).Text = ToHumanDate(unixtime);

                // Picture
                if (item.Cover == null)
                {
                    view.FindViewById<ImageView>(Resource.Id.gameCover).SetImageResource(Resource.Drawable.no_picture2);
                }
                else
                {
                    string apiBaseURL = "https:" + item.Cover.Url;
                    var imageView = view.FindViewById<ImageView>(Resource.Id.gameCover);

                    string coverBig = apiBaseURL.Replace("/t_thumb/", "/t_cover_big/");

                    ImageService.Instance.LoadUrl(coverBig).Into(imageView);
                }
                DateTime localTime = DateTime.Now;
                string unixTime = item.FirstReleaseDate.ToString();
                double unixtime2 = Convert.ToDouble(unixTime);
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(unixtime2).ToLocalTime();
                if (localTime >= dtDateTime)
                {
                    view.FindViewById<TextView>(Resource.Id.countDownView).Text = "RL";
                }
                else
                {
                    var number = dtDateTime - localTime;
                    if (number.Days == 0)
                    {
                        var inHours = number.Hours;
                        view.FindViewById<TextView>(Resource.Id.countDownView).Text = inHours.ToString() + "h";
                    }
                    else if (number.Hours == 0)
                    {
                        var inMinutes = number.Minutes;
                        view.FindViewById<TextView>(Resource.Id.countDownView).Text = inMinutes.ToString() + "min";
                    }
                    else
                    {
                        var inDays = number.Days;
                        view.FindViewById<TextView>(Resource.Id.countDownView).Text = inDays.ToString() + "d";
                    }
                }
                return view;
        }
        public string ToHumanDate(string unixTime)
        {
            double unixtime2 = Convert.ToDouble(unixTime);
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime2).ToLocalTime();
            string gameReleaseDate = dtDateTime.ToString("dd MMM, yyyy");
            return gameReleaseDate;
        }   
    }
}