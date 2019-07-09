using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase.Database;
using Foundation;
using MTiRate;
using Race2IAS.iOS;
using Race2IAS.Model;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(RealTimeDatabase))]
namespace Race2IAS.iOS
{
    public class RealTimeDatabase : IRealTimeDatabase
    {

        List<Dailyquiz> DailyQuizList = new List<Dailyquiz>();
        string Q;
        public void Connect()
        {
            DatabaseReference rootNode = Database.DefaultInstance.GetRootReference();

            DatabaseReference foldersNode = rootNode.GetChild("count");
            DatabaseReference foldersNode1 = rootNode.GetChild("race2ias-219814");
            nuint handleReference = foldersNode.ObserveEvent(DataEventType.Value, (snapshot) => {
                var folderData = snapshot.GetValue<NSDictionary>();
                // Do magic with the folder data
                string question = folderData.Values.ToString();
                Q = question;
            });
        }
        public void Rate()
        {
            iRate.SharedInstance.MessageTitle = "Rate Race2IAS";
            iRate.SharedInstance.PromptForRating();
        }
    }
}