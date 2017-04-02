using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comunida.Models
{
    public class Calendar
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Status { get; set; }
        public int SlotLimit { get; set; }

        public Organization Organization { get; set; }
    }
}
