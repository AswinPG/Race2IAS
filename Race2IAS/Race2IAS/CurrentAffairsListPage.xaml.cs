using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Race2IAS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CurrentAffairsListPage : ContentPage
	{
		public CurrentAffairsListPage ()
		{
			InitializeComponent ();
		}

        private async void Recent_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarousalWebView(67, 466));
            await DisplayAlert("Current Affairs", "Swipe Right To View More ...!!", "Ok");
        }

        private async void August_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarousalWebView(1,66));
            await DisplayAlert("Current Affairs", "Swipe Right To View More ...!!", "Ok");
        }
    }
}