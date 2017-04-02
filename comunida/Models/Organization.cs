using System;
using System.Collections.Generic;

namespace comunida.Models
{
    public class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Requirements { get; set; }

        public ICollection<Calendar> Calendars { get; set; }
        public ICollection<Interest> Interests { get; set; }
    }
}
