using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Api.Core;
using GameReleases.Activities;
using GameReleases.Adapter;
using Newtonsoft.Json;
using static Android.Widget.AdapterView;

namespace GameReleases.Fragments
{
    class FebFragment : Android.Support.V4.App.Fragment
    {
        private ListView february2020LV;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.february2020, container, false);
            february2020LV = view.FindViewById<ListView>(Resource.Id.february2020ListView);

            OnResume();
            return view;
        }
        async public new void OnResume()
        {
            base.OnResume();

            var gameDataFeb = await DataService.GetDataForFebruary2020(Resources.GetString(Resource.String.api_key));
            february2020LV.Adapter = new Feb2020Adapter(this, gameDataFeb);

            february2020LV.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                var gameDetails = gameDataFeb[e.Position];

                var intent = new Intent(Activity, typeof(GameDetailsActivity));
                intent.PutExtra("gameDetails", JsonConvert.SerializeObject(gameDetails));
                StartActivity(intent);
            };

            february2020LV.FastScrollEnabled = true;

        }
    }
}