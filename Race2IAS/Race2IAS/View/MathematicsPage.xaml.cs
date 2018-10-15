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
	public partial class MathematicsPage : ContentPage
	{
		public MathematicsPage ()
		{
			InitializeComponent ();
		}

        private async void OperationonNumbersTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/operation-number.html"));
        }

        private async void DecimalfractionHCFandLCMTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/fraction-hcf-lcm.html"));
        }
    }
}