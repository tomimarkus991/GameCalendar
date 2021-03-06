﻿using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Api.Core;
using GameReleases.Activities;
using GameReleases.Adapter;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using static Android.Widget.AdapterView;

namespace GameReleases.Fragments
{
    class JanFragment : Android.Support.V4.App.Fragment
    {
        private ListView january2020LV;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.january2020, container, false);
            january2020LV = view.FindViewById<ListView>(Resource.Id.january2020ListView);

            OnResume();

            return view;
        }
        async public new void OnResume()
        {
            var gameDataJan = await DataService.GetDataForJanuary2020(Resources.GetString(Resource.String.api_key));
            january2020LV.Adapter = new Jan2020Adapter(this, gameDataJan);
            january2020LV.FastScrollEnabled = true;

            DateTime dt = new DateTime();
            var yes = dt.ToLocalTime();
            yes.ToUniversalTime();

            january2020LV.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                var gameDetails = gameDataJan[e.Position];
                JanFragment janFragment = new JanFragment();
                var intent = new Intent(Activity, typeof(GameDetailsActivity));
                intent.PutExtra("gameDetails", JsonConvert.SerializeObject(gameDetails));
                StartActivity(intent);
            };
        }
    }
}