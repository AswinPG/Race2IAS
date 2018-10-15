using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Race2IAS.iOS;
using UIKit;
using Xamarin.Forms;

[assembly : Dependency(typeof(BaseUrl_iOS))]
namespace Race2IAS.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}