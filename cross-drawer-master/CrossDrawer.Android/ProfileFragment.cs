using Android.OS;
using Android.Runtime;
using Android.Views;
using CrossDrawer.Core;
using CrossDrawer.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace CrossDrawer.Android
{
    [MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.frameLayout)]
    [Register("crossdrawer.android.ProfileFragment")]
    public class ProfileFragment : MvxFragment<ProfileViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.ProfileView, null);

        }

        public override void OnResume()
        {
            // ViewModel.OnResume();
            ((ProfileViewModel)ViewModel).OnResume();
            base.OnResume();
        }
    }
}