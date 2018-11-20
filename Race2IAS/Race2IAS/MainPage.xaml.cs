using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Race2IAS
{
    public partial class MainPage : ContentPage
    {
        private int SlidePosition = 0;

        public MainPage()
        {
            InitializeComponent();
            var names = new List<string>
            {
                "wl.png","wl2.png","wl3.png","wl4","wl5.png" ,"wl6" 
            };
            MainCarouselView.ItemsSource = names;

            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                SlidePosition++;
                if (SlidePosition == names.Count)
                {
                    SlidePosition = 0;
                }
                MainCarouselView.Position = SlidePosition;
                return true;
            });
        }

        private async void CurrentAffairs_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CurrentAffairsListPage());
        }

        private async void MockTestTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MockTestPage());
        }

        private async void Race2IASTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlainWebView("race2ias.html"));
        }

        private async void Quiz_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage());
        }

        private async void StudyNotesPageTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudyNotesPage());
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Race2IAS", "No  Notifications Yet", "Okay");
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
