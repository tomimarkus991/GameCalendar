using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Api.Core;
using GameReleases.Adapter;
using Newtonsoft.Json.Linq;

namespace GameReleases.Activities
{
    [Activity(Label = "SearchActivity")]
    public class SearchActivity : Activity
    {
        //AutoCompleteTextView searchbar1;
        AutoCompleteTextView autoCompleteTextView;
        ListView searchLV;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.search_layout);

            //searchLV = FindViewById<ListView>(Resource.Id.searchItemListView);

            //var adapter = new ArrayAdapter(this, Resource.Layout.game_row);

            //autoCompleteTextView.Adapter = new SearchAdapter(this, gameSearchData.Result);

            var autoCompleteOptions = new string[] { "hello", "Hey", "fuck off", "nein" };
            var gameSearchData = DataService.GetDataFromSearch(Resources.GetString(Resource.String.api_key));
            //ArrayAdapter autoCompleteAdapter = new ArrayAdapter
            //    (this, Android.Resource.Layout.SimpleDropDownItem1Line, gameSearchData);
            
            autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.searchbar1);
            //autoCompleteTextView.Adapter(new SearchAdapter(this, Android.Resource.Layout.SimpleListItem1));
            //autoCompleteTextView.Adapter = autoCompleteAdapter;

            //autoCompleteTextView.Adapter = adapter;
            //gameListView.ItemClick += (object sender, ItemClickEventArgs e) =>
            //{
            //    var gameDetails = gameData.Result[e.Position];

            //    var intent = new Intent(this, typeof(GameDetailsActivity));
            //    intent.PutExtra("gameDetails", JsonConvert.SerializeObject(gameDetails));
            //    StartActivity(intent);
            //};
        }      
    }
}