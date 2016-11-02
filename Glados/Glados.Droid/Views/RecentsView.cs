using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Glados.Droid.Views
{
    [Activity(Label = "View for RecentsViewModel", Theme = "@android:style/Theme.Holo.Light.NoActionBar")]

    public class RecentsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RecentsView);
            // this is a test
        }
    }
}