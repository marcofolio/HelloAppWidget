using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAppWidget
{
	[Activity(Label = "HelloApp Widget", MainLauncher = true, Icon = "@drawable/android")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			Toast.MakeText(this, "Long-press the homescreen to add the widget", ToastLength.Long).Show();

			Finish();
		}
	}
}

