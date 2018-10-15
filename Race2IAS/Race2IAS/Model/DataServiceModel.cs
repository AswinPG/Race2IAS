using System;
using System.Collections.Generic;
using System.Text;

namespace Race2IAS.Model
{
    public class DataServiceModel
    {
        public List<questions> data = new List<questions>
        {
            new questions
            {
                _id= 1 ,
                Question = ".…………………………for Excellence in Public Administration, Academics and Management.\n1.The Lal Bahadur Shastri National award\n2.The Dhanwantri award\n3.The Bihari Award\n4.The Param Vir Chakra",
                OptionA = "A",
                OptionB = "B",
                OptionC = "C",
                OptionD = "D",
                Answer = "A"
 
            },
            new questions
            {
                _id= 2 ,
                Question = "gfhjdgfhjdgj",
                OptionA = "A",
                OptionB = "B",
                OptionC = "C",
                OptionD = "D",
                Answer = "D"

            }
        };
    }
}
