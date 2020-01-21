using Android.Content.Res;
using Android.Runtime;
using Android.Support.V4.App;

namespace GameReleases.Adapter
{
    class PagerAdapter : FragmentPagerAdapter
    {
        private JavaList<Fragment> fragments;
        public PagerAdapter(FragmentManager fm, JavaList<Fragment> fragments) :base(fm)
        {
            this.fragments = fragments;
        }
        public override int Count
        {
            get{ return fragments.Count; }
        }
        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }
        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            if (position == 0)
            {
                return new Java.Lang.String("January 2020");
            }
            else if (position == 1)
            {
                return new Java.Lang.String("February 2020");
            }
            else if (position == 2)
            {
                return new Java.Lang.String("March 2020");
            }
            return new Java.Lang.String();
        }
    }
}