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
    class MarchFragment : Android.Support.V4.App.Fragment
    {
        private ListView march2020LV;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.march2020, container, false);
            march2020LV = view.FindViewById<ListView>(Resource.Id.march2020ListView);

            var gameDataMarch = DataService.GetDataForMarch2020(Resources.GetString(Resource.String.api_key));
            march2020LV.Adapter = new March2020Adapter(this, gameDataMarch.Result);

            march2020LV.FastScrollEnabled = true;
            march2020LV.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                var gameDetails = gameDataMarch.Result[e.Position];
                JanFragment janFragment = new JanFragment();
                var intent = new Intent(Activity, typeof(GameDetailsActivity));
                intent.PutExtra("gameDetails", JsonConvert.SerializeObject(gameDetails));
                StartActivity(intent);
            };
            return view;
        }
    }
}