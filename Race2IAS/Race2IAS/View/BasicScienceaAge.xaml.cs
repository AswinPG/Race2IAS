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
    public partial class BasicScienceaAge : ContentPage
    {
        public BasicScienceaAge()
        {
            InitializeComponent();
        }

        private async void ScienceAndSenseOrgansTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://google.com"));
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}