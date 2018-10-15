using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Race2IAS.Model
{
    [Table("questions")]
    public class questions
    {
        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
    }
}
