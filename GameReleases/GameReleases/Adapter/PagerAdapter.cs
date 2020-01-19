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
            //switch (position)
            //{
            //    case 0:
            //        return new Java.Lang.String("January 2020");
            //    case 1:
            //        return new Java.Lang.String("February 2020");
            //    case 2:
            //        return new Java.Lang.String("March 2020");
            //    //case 3:
            //    //    return new Java.Lang.String("April 2020");
            //    //case 4:
            //    //    return new Java.Lang.String("May 2020");
            //    //case 5:
            //    //    return new Java.Lang.String("June 2020");
            //    //case 6:
            //    //    return new Java.Lang.String("July 2020");
            //    //case 7:
            //    //    return new Java.Lang.String("August 2020");
            //    //case 8:
            //    //    return new Java.Lang.String("September 2020");
            //    //case 9:
            //    //    return new Java.Lang.String("Spooktober 2020");
            //    //case 10:
            //    //    return new Java.Lang.String("November 2020");
            //    //case 11:
            //    //    return new Java.Lang.String("December 2020");
            //    //case 12:
            //    //    return new Java.Lang.String("January 2021");
            //}

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