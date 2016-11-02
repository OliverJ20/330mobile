using Android.OS;
using Android.Runtime;
using Android.Views;
using CrossDrawer.Core;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace CrossDrawer.Android
{
	[MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.frameLayout)]
	[Register("crossdrawer.android.RecentsFragment")]
	public class RecentsFragment : MvxFragment<RecentsViewModel>
	{
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.RecentsView, null);

        }

        public override void OnResume()
        {
 
            ((RecentsViewModel)ViewModel).OnResume();
            base.OnResume();
        }
    }
}