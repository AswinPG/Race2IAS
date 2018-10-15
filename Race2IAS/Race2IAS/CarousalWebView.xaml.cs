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
	public partial class CarousalWebView : ContentPage
	{
        public int i;

        public CarousalWebView (int a, int b)
		{
			InitializeComponent ();
            List<string>  Webpages = new List<string>
            {

            };
            AddData(a,b,Webpages);
            MainCarouselView.ItemsSource = Webpages;
            
        }

        public void AddData(int init, int final, List<string> List)
        {
            for (i = final; i >= init; i--)
            {
                List.Add("https://iautotechindia.com/current_affairs/" + i + ".php");
            }
        }
    }
}