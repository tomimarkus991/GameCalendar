using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Widget;
using GameReleases.Fragments;
using System;
using Fragment = Android.Support.V4.App.Fragment;
using PagerAdapter = GameReleases.Adapter.PagerAdapter;

namespace GameReleases.Activities
{
    [Activity(MainLauncher = true)]
    public class MainActivity : FragmentActivity
    {
        ViewPager viewPager;
        private Android.Support.V4.App.FragmentManager fManager;
        private Adapter.PagerAdapter pAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main_layout);

            fManager = this.SupportFragmentManager;

            pAdapter = new PagerAdapter(fManager, GetFragments());

            viewPager = FindViewById<ViewPager>(Resource.Id.viewPager1);
            viewPager.Adapter = pAdapter;

            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            searchButton.Click += SearchButton_Click;

            //var gameListView = FindViewById<ListView>(Resource.Id.gamesListView);
            //var gameData = DataService.GetDataFromGame();
            //gameListView.Adapter = new GameAdapter(this, gameData.Result);
        }
        private JavaList<Fragment> GetFragments()
        {
            JavaList<Fragment> fragments = new JavaList<Fragment>();
            fragments.Add(new JanFragment());
            fragments.Add(new FebFragment());
            fragments.Add(new MarchFragment());
            return fragments;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SearchActivity));
            this.StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}