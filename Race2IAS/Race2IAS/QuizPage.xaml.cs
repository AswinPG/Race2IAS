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
            await Navigation.PushAsync(new SingleQuizPage("independance.db", 24));
        }

        private async void BiologyQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("biology.db", 40));
        }

        private async void ITQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("computer.db", 90));
        }

        private async void AwardsQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("awards.db", 40));
        }

        private async void PolityquizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("polity.db", 60));
        }

        private async void PhysicsQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("physics.db", 30));
        }

        private async void HistoryQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("history.db", 40));
        }

        private async void GeographyQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SingleQuizPage("geography.db", 55));
        }
    }
}