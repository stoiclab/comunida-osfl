using System;
using System.Collections.Generic;

namespace comunida.Models
{
    public class Person
    {
        public int ID { get; set; }
        public int UserId { get; set; }

        public ICollection<ApplicationUser> User { get; set; }
    }
}
