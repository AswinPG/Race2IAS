using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Race2IAS.Model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Race2IAS
{
    public partial class App : Application
    {
        public App(string dbPath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        
    }
}
