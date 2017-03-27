using Android.App;
using Android.Widget;
using Android.OS;

namespace BOOK_READER
{
	[Activity(Label = "BOOK_READER", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

			Button button1 = FindViewById<Button>(Resource.Id.btnSignup);
			Button button2 = FindViewById<Button>(Resource.Id.btnLogin);

			button1.Click += delegate { StartActivity(typeof(signupActivity)); };
			button2.Click += delegate { StartActivity(typeof(homeActivity)); };

		}
	}
}


