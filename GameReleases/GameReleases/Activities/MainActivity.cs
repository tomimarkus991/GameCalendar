using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using GameReleases.Fragments;
using System;
using System.Threading.Tasks;
using static Android.Support.V4.View.ViewPager;
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
            //viewPager.SetPageTransformer(true, new ZoomOutPageTransformer());
            viewPager.Adapter = pAdapter;

            //var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            //searchButton.Click += SearchButton_Click;

            //var gameListView = FindViewById<ListView>(Resource.Id.gamesListView);
            //var gameData = DataService.GetDataFromGame();
            //gameListView.Adapter = new GameAdapter(this, gameData.Result);
        }
        private JavaList<Fragment> GetFragments()
        {
            JavaList<Fragment> fragments = new JavaList<Fragment>
            {
                new JanFragment(),
                new FebFragment(),
                new MarchFragment()
            };
            return fragments;
        }
        //private void SearchButton_Click(object sender, EventArgs e)
        //{
        //    var intent = new Intent(this, typeof(SearchActivity));
        //    this.StartActivity(intent);
        //}
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public class ZoomOutPageTransformer : Java.Lang.Object, IPageTransformer
        {
            private static float MIN_SCALE = 0.85f;
            private static float MIN_ALPHA = 0.5f;

            public void TransformPage(View page, float position)
            {
                int pageWidth = page.Width;
                int pageHeight = page.Height;

                if (position < -1)
                {
                    page.Alpha = 0;
                }
                else if (position <= 1)
                {
                    float scaleFactor = Math.Max(MIN_SCALE, 1 - Math.Abs(position));
                    float vertMargin = pageHeight * (1 - scaleFactor) / 2;
                    float horzMargin = pageWidth * (1 - scaleFactor) / 2;
                    if (position < 0)
                        page.TranslationX = (horzMargin - vertMargin) / 2;
                    else
                        page.TranslationX = (vertMargin - horzMargin) / 2;

                    //Scale the page down
                    page.ScaleX = scaleFactor;
                    page.ScaleY = scaleFactor;

                    page.Alpha = (MIN_ALPHA + scaleFactor - MIN_SCALE) / (1 - MIN_SCALE) * (1 - MIN_ALPHA);
                }
                else
                {
                    page.Alpha = 0;
                }
            }
        }
    }
}