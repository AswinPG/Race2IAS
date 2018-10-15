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
	public partial class LogicalReasoningPage : ContentPage
	{
		public LogicalReasoningPage ()
		{
			InitializeComponent ();
		}

        private async void MoreProblemsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView(""));
        }

        private async void VerbalReasoningTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView(""));
        }

        private async void StatementandConclusionTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView(""));
        }

        private async void VisualProblemsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServerWebView(""));
        }
    }
}