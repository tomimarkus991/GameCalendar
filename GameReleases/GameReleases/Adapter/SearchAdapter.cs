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
using GameReleases.Activities;

namespace GameReleases.Adapter
{
    class SearchAdapter : BaseAdapter<Game>
    {
        private SearchActivity searchActivity;
        private List<Game> games;
        public SearchAdapter(SearchActivity searchActivity, List<Game> games)
        {
            this.searchActivity = searchActivity;
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
                view = searchActivity.LayoutInflater.Inflate(Resource.Layout.game_row, null);
            }

            view.FindViewById<AutoCompleteTextView>(Resource.Id.searchbar1).Text = item.Name;
            return view;
        }
    }
}