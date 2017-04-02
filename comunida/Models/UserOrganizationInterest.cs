using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace comunida.Models
{
    public class PersonOrganizationInterest
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual ICollection<Person> Person { get; protected set; }
        public virtual int UserId { get; set; }

        public virtual ICollection<Organization> Organization { get; protected set; }
        public virtual int OrganizationId { get; set; }

        public virtual ICollection<Interest> Interest { get; protected set; }
        public virtual int InterestId { get; set; }
    }
}
