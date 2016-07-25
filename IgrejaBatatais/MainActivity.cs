using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace IgrejaBatatais
{
	[Activity (Label = "Igreja Batatais", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.button1);
			
			button.Click += delegate {
				var uri = Android.Net.Uri.Parse ("http://www.igrejabatatais.com.br");
				var intent = new Intent (Intent.ActionView, uri);
				StartActivity (intent);
			};
		}
	}
}


