using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        ImageView addButton;
        ImageView searchButton;
        EditText searchText;
        RecyclerView myRecyclerView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myRecyclerView = (RecyclerView)FindViewById(Resource.Id.myRecyclerView);
        }
    }
}