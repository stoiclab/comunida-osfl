using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comunida.Models
{
    public class PersonInterest
    {
        public int ID { get; set; }
        public string PersonID { get; set; }
        public string InterestId { get; set; }

        public Interest Interest { get; set; }
        public Person Person { get; set; }
    }
}
