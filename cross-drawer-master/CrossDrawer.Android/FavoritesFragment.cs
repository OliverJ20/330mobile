using Android.OS;
using Android.Runtime;
using Android.Views;
using CrossDrawer.Core;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using CrossDrawer.Core.ViewModels;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Binding.Droid.BindingContext;
using Android.Widget;
using MvvmCross.Binding.BindingContext;

namespace CrossDrawer.Android
{
    [MvxFragmentAttribute(typeof(MainViewModel), Resource.Id.frameLayout)]
    [Register("crossdrawer.android.FavoritesFragment")]
    public class FavoritesFragment : MvxFragment<FavoriteViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
        //    return this.BindingInflate(Resource.Layout.FavoritesView, null);
         /*  var V = this.BindingInflate(Resource.Layout.FavoritesView, container, false);
            var ProfileChange = V.FindViewById<Button>(Resource.Id.ProfileButton);
            var set = this.CreateBindingSet<FavoritesFragment, FavoriteViewModel>();
             set.Bind(ProfileChange).To(vm => vm.ProfileSwitch);
            set.Apply();
           return V;*/
            
             return this.BindingInflate(Resource.Layout.FavoritesView, null);

        }

        public override void OnResume()
        {
            // ViewModel.OnResume();
            ((FavoriteViewModel)ViewModel).OnResume();
            base.OnResume();
        }
    }
}