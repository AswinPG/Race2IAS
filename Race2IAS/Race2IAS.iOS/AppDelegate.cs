using System;
using System.Collections.Generic;
using System.Linq;
using Firebase.CloudMessaging;
using Foundation;
using UIKit;
using UserNotifications;

namespace Race2IAS.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IUNUserNotificationCenterDelegate, IMessagingDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.

        public void DidRefreshRegistrationToken(Messaging messaging, string fcmToken)

        {

            System.Diagnostics.Debug.WriteLine($"FCM Token: {fcmToken}");

        }
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            //string dbPath = FileAccessHelper.GetLocalFilePath("awards.db");

            Firebase.Core.App.Configure();
            LoadApplication (new App());

            // Register your app for remote notifications.

            if (UIDevice.CurrentDevice.CheckSystemVersion(10, 0))

            {

                // iOS 10 or later

                var authOptions = UNAuthorizationOptions.Alert | UNAuthorizationOptions.Badge | UNAuthorizationOptions.Sound;

                UNUserNotificationCenter.Current.RequestAuthorization(authOptions, (granted, error) => {

                    Console.WriteLine(granted);

                });



                // For iOS 10 display notification (sent via APNS)

                //UNUserNotificationCenter.Current.Delegate = this;



                // For iOS 10 data message (sent via FCM)

                //Messaging.SharedInstance.RemoteMessageDelegate = this;

            }

            else

            {

                // iOS 9 or before

                var allNotificationTypes = UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound;

                var settings = UIUserNotificationSettings.GetSettingsForTypes(allNotificationTypes, null);

                UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);

            }



            UIApplication.SharedApplication.RegisterForRemoteNotifications();

            return base.FinishedLaunching(app, options);
        }
    }
}
