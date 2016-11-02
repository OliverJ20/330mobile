using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CrossDrawer.Core;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
 
using MvvmCross.Binding.Droid.BindingContext;

namespace CrossDrawer.Android
{
	[MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.frameLayout)]
	[Register("crossdrawer.android.HomeFragment")]
	public class HomeFragment : MvxFragment<HomeViewModel>
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
            this.EnsureBindingContextIsSet(savedInstanceState);
            var v = inflater.Inflate(Resource.Layout.HomeView, container, false);
            var favButton = v.FindViewById<Button>(Resource.Id.favouritesButton);
            var recButton = v.FindViewById<Button>(Resource.Id.RecentsButton);
            var setButton = v.FindViewById<Button>(Resource.Id.SettingsButton);
            var proButton = v.FindViewById<Button>(Resource.Id.ProfileButton);
         //   var arrowButton = v.FindViewById<Button>(Resource.Id.favarrow);
            var set = this.CreateBindingSet<HomeFragment, HomeViewModel>();
            set.Bind(favButton).To(vm => vm.FavoritesNav);
            set.Bind(recButton).To(vm => vm.RecentsNav);
            set.Bind(setButton).To(vm => vm.SettingsNav);
            set.Bind(proButton).To(vm => vm.ProfileNav);
          //  set.Bind(arrowButton).To(vm => vm.ProfileNav);
            set.Apply();
            return v;
        }
	}
}