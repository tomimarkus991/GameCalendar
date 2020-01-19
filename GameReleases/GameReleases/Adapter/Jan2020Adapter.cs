using Android.Views;
using Android.Widget;
using Api.Core;
using FFImageLoading;
using GameReleases.Fragments;
using System;
using System.Collections.Generic;

namespace GameReleases.Adapter
{
    class Jan2020Adapter : BaseAdapter<Game>
    {
        private JanFragment janFragment;
        private List<Game> games;
        public Jan2020Adapter(JanFragment janFragment, List<Game> games)
        {
            this.janFragment = janFragment;
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
                view = janFragment.LayoutInflater.Inflate(Resource.Layout.game_row, null);
            }

            view.FindViewById<TextView>(Resource.Id.name).Text = item.Name;
            DateTime localTime = DateTime.Now;
            string unixTime = item.FirstReleaseDate.ToString();
            double unixtime2 = Convert.ToDouble(unixTime);
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime2).ToLocalTime();
            if (localTime <= dtDateTime)
            {
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
                    int x = item.Platforms.Count;
                    switch (x)
                    {
                        case 1:
                            foreach (var platform in item.Platforms)
                            {
                                if (platform.Id == 3)
                                {
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                                }
                                else if (platform.Id == 6 || platform.Id == 92)
                                {
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                                }
                                else if (platform.Id == 14)
                                {
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                                }
                                else if (platform.Id == 48)
                                {
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                                }
                                else if (platform.Id == 49)
                                {
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "XboxO ";
                                }
                                else if (platform.Id == 130)
                                {
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                                }
                            }
                            break;
                        case 2:
                            foreach (var platform in item.Platforms)
                            {
                                if (platform.Id == 3)
                                {
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                                }
                                else if (platform.Id == 6 || platform.Id == 92)
                                {
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                                }
                                else if (platform.Id == 14)
                                {
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                                }
                                else if (platform.Id == 48)
                                {
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                                }
                                else if (platform.Id == 49)
                                {
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "XboxO ";
                                }
                                else if (platform.Id == 130)
                                {
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                                }
                            }
                            break;
                        case 3:
                            foreach (var platform in item.Platforms)
                            {
                                if (platform.Id == 3)
                                {
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                                }
                                else if (platform.Id == 6 || platform.Id == 92)
                                {
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                                }
                                else if (platform.Id == 14)
                                {
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                                }
                                else if (platform.Id == 48)
                                {
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                                }
                                else if (platform.Id == 49)
                                {
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "XboxO ";
                                }
                                else if (platform.Id == 130)
                                {
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                                }
                            }
                            break;
                        case 4:
                            foreach (var platform in item.Platforms)
                            {
                                if (platform.Id == 3)
                                {
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                                }
                                else if (platform.Id == 6 || platform.Id == 92)
                                {
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                                }
                                else if (platform.Id == 14)
                                {
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                                }
                                else if (platform.Id == 48)
                                {
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                                }
                                else if (platform.Id == 49)
                                {
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "XboxO ";
                                }
                                else if (platform.Id == 130)
                                {
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
                                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.alreadyReleased).Text = "Already Released";
            }

            // Time
            string unixtime = item.FirstReleaseDate.ToString();
            view.FindViewById<TextView>(Resource.Id.releaseDate).Text = ToHumanDate(unixtime);

            // Picture
            if (item.Cover == null)
            {
                view.FindViewById<ImageView>(Resource.Id.gameCover).SetImageResource(Resource.Drawable.no_picture);
            }
            else
            {
                string apiBaseURL = item.Cover.Url;
                var imageView = view.FindViewById<ImageView>(Resource.Id.gameCover);
                ImageService.Instance.LoadUrl("https:" + apiBaseURL).Into(imageView);
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