using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Race2IAS.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GeographyPage : ContentPage
	{
		public GeographyPage ()
		{
			InitializeComponent ();
		}

        private async void EarthAndUniverseTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/earth-and-universe.html"));
        }

        private async void StarsandtheSolarSystemTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Stars%20and%20the%20Solar%20System.htm"));
        }
    }
}