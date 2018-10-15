using System;
using System.Collections.Generic;
using System.Text;

namespace Race2IAS.Model
{
    public class Score
    {
        public double Total { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }

        public Score()
        {
            Total = 0;
            Correct = 0;
            Wrong = 0;
        }
    }
}
