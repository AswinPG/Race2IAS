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
	public partial class EnvironmentPage : ContentPage
	{
		public EnvironmentPage ()
		{
			InitializeComponent ();
		}

        private async void NaturalResourcesandPollutionsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/natural-resources-and-pollution.html"));
        }

        private async void PlantWorldTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/plant-world.html"));
        }

        private async void OurEnvironmentTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/our-environment.html"));
        }

        private async void ConservationofPlantsandAnimalsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Conservation%20of%20Plants%20and%20Animals.htm"));
        }

        private async void CropProductionandManagementTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Crop%20Production%20and%20Management.htm"));
        }

        private async void PollutionofAirTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Pollution.htm"));
        }

        private async void NaturalResourcesandTheirConservationTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView("https://www.iautotechindia.com/studynotes/Natural%20Resources%20and%20Their%20Conservation.htm"));
        }
    }
}