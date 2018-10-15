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
	public partial class IndianPolityPage : ContentPage
	{
		public IndianPolityPage ()
		{
			InitializeComponent ();
		}

        private async void StateExecutiveTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/state-executive.html"));
        }

        private async void CentralExecutiveTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/central-executive.html"));
        }

        private async void CloseToUsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/closetous.html"));
        }

        private async void ElectionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/election.html"));
        }

        private async void PermanentExecutiveTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/permanent-executive.html"));
        }
    }
}