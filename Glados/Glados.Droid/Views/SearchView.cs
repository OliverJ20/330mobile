using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Glados.Droid.Views
{
    [Activity(Label = "View for SearchViewModel", Theme = "@android:style/Theme.Holo.Light.NoActionBar")]

    public class SearchView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SearchView);
            // this is a test
        }
    }
}