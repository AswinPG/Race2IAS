using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Race2IAS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlainWebView : ContentPage
	{
		public PlainWebView (string path)
		{
			InitializeComponent ();
            
            var urlSource = new UrlWebViewSource();
            string url = DependencyService.Get<IBaseUrl>().Get();
            string Tempurl = Path.Combine(url, path);
            urlSource.Url = Tempurl;
            PlainWeb.Source = urlSource;

		}
	}
}