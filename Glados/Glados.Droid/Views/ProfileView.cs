using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Glados.Droid.Views
{
    [Activity(Label = "View for ProfileViewModel", Theme = "@android:style/Theme.Holo.Light.NoActionBar")]

    public class ProfileView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ProfileView);
            // this is a test
        }
    }
}