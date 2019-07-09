using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Firebase.Auth;
using Foundation;
using UIKit;
using Race2IAS.iOS;
using System.Diagnostics;

[assembly: Dependency(typeof(FirebaseAuthenticator))]
namespace Race2IAS.iOS
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            //var user = await Auth.DefaultInstance.SignInAsync(email, password);
            //return await user.GetIdTokenAsync();
            throw new NotImplementedException();
        }

        public async Task<string> RegsiterWithEmailPassword(string email, string password)
        {
            //var user = await Firebase.Auth.Auth.DefaultInstance.CreateUserAsync(email, password);
            //return await user.GetIdTokenAsync();
            throw new NotImplementedException();
        }

        public async Task<string> PhoneAuth(string number, string Name)
        {
            try
            {
                string verificationID = await PhoneAuthProvider.DefaultInstance.VerifyPhoneNumberAsync(number, null);
                NSUserDefaults.StandardUserDefaults.SetString(verificationID, "verificationID");
                NSUserDefaults.StandardUserDefaults.SetString(Name, "UserName");
                NSUserDefaults.StandardUserDefaults.Synchronize();
                verificationID = NSUserDefaults.StandardUserDefaults.StringForKey("verificationID");
                return verificationID;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return e.ToString();
            }
        }

        public async void Login(string ver, string num)
        {
            //NSUserDefaults.StandardUserDefaults.SetString("true", "Login");
            //NSUserDefaults.StandardUserDefaults.Synchronize();
            //var credential = PhoneAuthProvider.DefaultInstance.GetCredential(ver, num);
            try
            {
                var credential = PhoneAuthProvider.DefaultInstance.GetCredential(ver, num);
                var result = await Auth.DefaultInstance.SignInAndRetrieveDataWithCredentialAsync(credential);
                NSUserDefaults.StandardUserDefaults.SetString("true", "Login");
                NSUserDefaults.StandardUserDefaults.Synchronize();
            }
            catch (Exception e)
            {
                NSUserDefaults.StandardUserDefaults.SetString("false", "Login");
                NSUserDefaults.StandardUserDefaults.Synchronize();
            }

            //Debug.WriteLine("write");
        }
        public string loggedinornot()
        {
            return NSUserDefaults.StandardUserDefaults.StringForKey("Login");
        }

        public string GetUserName()
        {
            return NSUserDefaults.StandardUserDefaults.StringForKey("UserName");
        }

    }
}