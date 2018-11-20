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
    public partial class LoginPage : ContentPage
    {

        public string x,otpp,y;
        public LoginPage()
        {
            InitializeComponent();
            
            //Result.Text = x;
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (number.Text == "" || name.Text == "")
            {
                await DisplayAlert("Invalid Operation","Give phone Number and Password","Okay");
            }
            else
            {
                x = number.Text;
                y = await DependencyService.Get<IFirebaseAuthenticator>().PhoneAuth("+91" + x);
                //await Navigation.PopAsync();
                number.IsVisible = false;
                fir2.IsVisible = false;
                Fir1.IsVisible = false;
                name.IsVisible = false;
                otp.IsVisible = true;
                submit.IsVisible = false;
                login.IsVisible = true;
                askotp.IsVisible = true;
                
                
                //DependencyService.Get<IFirebaseAuthenticator>().Login(y,otpp);
                //Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            
            
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            try
            {
                otpp = otp.Text;
                DependencyService.Get<IFirebaseAuthenticator>().Login(y, otpp);
                Application.Current.MainPage = new NavigationPage(new MainPage());
            }
            catch
            {
                DisplayAlert("Error", "Login Failed", "Try again");
                //await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}