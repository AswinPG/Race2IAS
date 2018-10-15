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
	public partial class StudyNotesPage : ContentPage
	{
		public StudyNotesPage ()
		{
			InitializeComponent ();
		}

        private async void PolityTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.IndianPolityPage());
        }

        private async void HistoryTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.HistoryPage());
        }

        private async void GeographyTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.GeographyPage());
        }

        private async void ScienceAndTechnologyTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Race2IAS", "Available Soon..", "OK");
        }

        private async void MathematicsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.MathematicsPage());
        }

        private async void IndianEconomyTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Race2IAS", "Available Soon..", "OK");
        }

        private async void EnvironmentTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.EnvironmentPage());
        }

        private async void LogialReasoningTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Race2IAS", "Available Soon..", "OK");
        }
    }
}