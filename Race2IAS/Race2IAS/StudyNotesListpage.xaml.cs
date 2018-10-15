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
	public partial class StudyNotesListpage : ContentPage
	{
		public StudyNotesListpage ()
		{
			InitializeComponent ();
            
            var Res = new List<Resource>
            {
                new Resource()
                {
                    SerialNumber = "1.",
                    MonthName="ASdfxdf"
                },
                new Resource()
                {
                    SerialNumber = "2.",
                    MonthName="ASdfxdf"
                },
                new Resource()
                {
                    SerialNumber = "3.",
                    MonthName="ASdfxdf"
                },
                new Resource()
                {
                    SerialNumber = "4.",
                    MonthName="ASdfxdf"
                }
            };
            MainListView.ItemsSource = Res;
   		}
        //MainListView.ItemSource = Res;
    }

    public class Resource
    {
        public string SerialNumber { get; set; }
        public string MonthName { get; set; }
    }
}