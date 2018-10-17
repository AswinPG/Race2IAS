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
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private async void FreedomQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("independance", 24));
        }

        private async void BiologyQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("biology", 40));
        }

        private async void ITQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("computer", 90));
        }

        private async void AwardsQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("awards", 40));
        }

        private async void PolityquizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("polity", 60));
        }

        private async void PhysicsQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("physics", 30));
        }

        private async void HistoryQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("history", 40));
        }

        private async void GeographyQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("geography", 55));
        }
    }
}