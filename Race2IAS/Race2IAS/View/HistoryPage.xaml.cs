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
	public partial class HistoryPage : ContentPage
	{
		public HistoryPage ()
		{
			InitializeComponent ();
		}

        private async void IndusValleyTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/indusvalley-civilization.html"));
        }

        private async void EmpiresInAncientIndiaTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/empires-ancientindia.html"));
        }

        private async void WarAndMessengerOfPeaceTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/war-messenger-peace.html"));
        }

        private async void SocialReformersTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/social-reformers.html"));
        }

        private async void NationalSymbolsandMonumentsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Indica.html"));
        }
    }
}