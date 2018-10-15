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
	public partial class ServerWebView : ContentPage
	{
		public ServerWebView (string url )
		{
			InitializeComponent ();
            ServerWeb.Source = url;
		}
	}
}