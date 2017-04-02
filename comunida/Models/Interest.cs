using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comunida.Models
{
    public class Interest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Organization Organization { get; set; }
        public ApplicationUser User { get; set; }
    }
}
