using System;
using System.Collections.Generic;

namespace comunida.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string about { get; set; }
        public string availability { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public int UserId { get; set; }

       // public ICollection<ApplicationUser> User { get; set; }
    }
}
