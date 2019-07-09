using System;
using System.Collections.Generic;
using System.Text;

namespace Race2IAS.Model
{

    public class DatabaseData
    {
        public string app_title { get; set; }
        public string count { get; set; }
        public Dailyquiz dailyquiz { get; set; }
        public Dailyquiz_2 dailyquiz_2 { get; set; }
        public Notifications notifications { get; set; }
        public Users users { get; set; }
    }

    public class Loehdmyumbl8ruqOH_
    { 
        public string answer { get; set; }
        public string opta { get; set; }
        public string optb { get; set; }
        public string optc { get; set; }
        public string optd { get; set; }
        public string question { get; set; }
    }

    public class Lsvj9awyv_Yuaszckop
    {
        public string cat { get; set; }
        public string ctds { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public string school { get; set; }
        public string uid { get; set; }
    }


    public class Dailyquiz
    {
        public string answer { get; set; }
        public string opta { get; set; }
        public string optb { get; set; }
        public string optc { get; set; }
        public string optd { get; set; }
        public string question { get; set; }

        public Dailyquiz(string ques, string ans,string opa, string opb, string opc, string opd)
        {
            answer = ans;
            opta = opa;
            optb = opb;
            optc = opc;
            optd = opd;
            question = ques;
        }
    }

    public class Dailyquiz_2
    {
        public Loehdmyumbl8ruqOH_ LOEHDMYumBl8rUqOH_ { get; set; }
    }

    public class Notifications
    {
        string notification;
    }

    public class Users
    {
        public Lsvj9awyv_Yuaszckop lsvj9Awyv_Yuaszckop { get; set; }
    }
}