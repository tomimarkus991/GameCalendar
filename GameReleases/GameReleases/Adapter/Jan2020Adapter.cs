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
        public override View GetView(int position, View view, ViewGroup parent)
        {
            if (view == null)
            {
                view = janFragment.LayoutInflater.Inflate(Resource.Layout.game_row, null);
            }
                GetName(position, view);
                GetPlatforms(position, view);
                CalculateReleaseDate(position, view);
                GetAndDisplayImage(position, view);
                CalculateDaysRemainingUntilRelease(position, view);

            return view;
        }
        public void GetName(int position, View view)
        {
            var item = games[position];

            view.FindViewById<TextView>(Resource.Id.name).Text = item.Name;
        }
        public void CalculateReleaseDate(int position, View view)
        {
            var item = games[position];

            string unixTime = item.FirstReleaseDate.ToString();
            double unixtime2 = Convert.ToDouble(unixTime);
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime2).ToLocalTime();
            string gameReleaseDate = dtDateTime.ToString("dd MMM, yyyy");
            view.FindViewById<TextView>(Resource.Id.releaseDate).Text = gameReleaseDate;
        }
        public void GetPlatforms(int position, View view)
        {
            var item = games[position];
            view.FindViewById<TextView>(Resource.Id.linux).Text = "";
            view.FindViewById<TextView>(Resource.Id.nWii).Text = "";
            view.FindViewById<TextView>(Resource.Id.pc).Text = "";
            view.FindViewById<TextView>(Resource.Id.ps3).Text = "";
            view.FindViewById<TextView>(Resource.Id.xbox360).Text = "";
            view.FindViewById<TextView>(Resource.Id.mac).Text = "";
            view.FindViewById<TextView>(Resource.Id.android).Text = "";
            view.FindViewById<TextView>(Resource.Id.n3DS).Text = "";
            view.FindViewById<TextView>(Resource.Id.iOS).Text = "";
            view.FindViewById<TextView>(Resource.Id.ps4).Text = "";
            view.FindViewById<TextView>(Resource.Id.xboxO).Text = "";
            view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
            view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "";
            view.FindViewById<TextView>(Resource.Id.steamVR).Text = "";
            view.FindViewById<TextView>(Resource.Id.oculusVR).Text = "";
            view.FindViewById<TextView>(Resource.Id.psVR).Text = "";
            view.FindViewById<TextView>(Resource.Id.ps5).Text = "";
            view.FindViewById<TextView>(Resource.Id.xboxX).Text = "";

            foreach (var platform in item.Platforms)
            {
                if (platform.Id == 3)
                {
                    view.FindViewById<TextView>(Resource.Id.linux).Text = "Linux ";
                }
                else if (platform.Id == 5)
                {
                    view.FindViewById<TextView>(Resource.Id.nWii).Text = "Wii ";
                }
                else if (platform.Id == 6 || platform.Id == 92)
                {
                    view.FindViewById<TextView>(Resource.Id.pc).Text = "PC ";
                }
                else if (platform.Id == 9)
                {
                    view.FindViewById<TextView>(Resource.Id.ps3).Text = "PS3 ";
                }
                else if (platform.Id == 12)
                {
                    view.FindViewById<TextView>(Resource.Id.xbox360).Text = "Xbox 360 ";
                }
                else if (platform.Id == 14)
                {
                    view.FindViewById<TextView>(Resource.Id.mac).Text = "Mac ";
                }
                else if (platform.Id == 34)
                {
                    view.FindViewById<TextView>(Resource.Id.android).Text = "Android ";
                }
                else if (platform.Id == 37)
                {
                    view.FindViewById<TextView>(Resource.Id.n3DS).Text = "Nintendo 3DS ";
                }
                else if (platform.Id == 39)
                {
                    view.FindViewById<TextView>(Resource.Id.iOS).Text = "iOS ";
                }
                else if (platform.Id == 48)
                {
                    view.FindViewById<TextView>(Resource.Id.ps4).Text = "PS4 ";
                }
                else if (platform.Id == 49)
                {
                    view.FindViewById<TextView>(Resource.Id.xboxO).Text = "Xbox One ";
                }
                else if (platform.Id == 130)
                {
                    view.FindViewById<TextView>(Resource.Id.nSwitch).Text = "Switch ";
                }
                else if (platform.Id == 162)
                {
                    view.FindViewById<TextView>(Resource.Id.steamVR).Text = "Steam VR ";
                }
                else if (platform.Id == 163)
                {
                    view.FindViewById<TextView>(Resource.Id.oculusVR).Text = "Oculus VR ";
                }
                else if (platform.Id == 165)
                {
                    view.FindViewById<TextView>(Resource.Id.psVR).Text = "PSVR ";
                }
                else if (platform.Id == 167)
                {
                    view.FindViewById<TextView>(Resource.Id.ps5).Text = "PS5 ";
                }
                else if (platform.Id == 169)
                {
                    view.FindViewById<TextView>(Resource.Id.xboxX).Text = "Xbox Series X ";
                }
            }
        }
        public void GetAndDisplayImage(int position, View view)
        {
            var item = games[position];

            view.FindViewById<ImageView>(Resource.Id.gameCover).SetImageResource(Resource.Drawable.white);
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
        }
        public void CalculateDaysRemainingUntilRelease(int position, View view)
        {
            var item = games[position];

            DateTime localTime = DateTime.Now;
            string unixTime = item.FirstReleaseDate.ToString();
            double unixtime2 = Convert.ToDouble(unixTime);
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime2).ToLocalTime();
            if (localTime >= dtDateTime)
            {
                view.FindViewById<TextView>(Resource.Id.countDownView).Text = "Released";
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
        }
    }
}