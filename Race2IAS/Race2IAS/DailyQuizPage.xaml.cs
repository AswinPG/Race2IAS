
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
    public partial class DailyQuizPage : ContentPage
    {
        //DBFirebase DB;
        public DailyQuizPage()
        {
            InitializeComponent();
            //DB = new DBFirebase();
            //TestListView.BindingContext = DB.GetQuestion();
        }
    }
}