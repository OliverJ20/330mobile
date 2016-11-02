using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Glados.Droid.Views
{
    [Activity(Label = "View for SettingsViewModel", Theme = "@android:style/Theme.Holo.Light.NoActionBar")]
    public class SettingsView : MvxActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SettingsView);
            // this is a test
        }
    }
}