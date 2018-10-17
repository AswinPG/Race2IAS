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
	public partial class MockTestPage : ContentPage
	{
		public MockTestPage ()
		{
			InitializeComponent ();
		}

        private async void c1Paper1Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleMockTestPage("mocktest1", 50,3));
        }

        private async void c2paper1Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleMockTestPage("mocktest2", 50 , 4));
        }

        private async void CSAT1Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HtmlMockTestPage("csat1", 50 ,1));
        }

        private async void CSAT2Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HtmlMockTestPage("csat2", 50, 2));
        }
    }
}