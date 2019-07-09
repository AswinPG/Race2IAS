using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Race2IAS
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string email, string password);
        Task<string> RegsiterWithEmailPassword(string email, string password);
        Task<string> PhoneAuth(string number, string Name);
        void Login(string ver, string num);
        string loggedinornot();
        string GetUserName();
    }
}
