using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Glados.Droid.Views
{
    [Activity(Label = "View for FavoriteViewModel", Theme = "@android:style/Theme.Holo.Light.NoActionBar")]

    public class FavoriteView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FavoriteView);
            // this is a test
        }
    }
}