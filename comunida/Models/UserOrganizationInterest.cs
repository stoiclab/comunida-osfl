using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comunida.Models
{
    public class UserOrganizationInterest
    {
        public virtual ICollection<ApplicationUser> User { get; protected set; }
        public virtual int UserId { get; set; }

        public virtual ICollection<Organization> Organization { get; protected set; }
        public virtual int OrganizationId { get; set; }

        public virtual ICollection<Interest> Interest { get; protected set; }
        public virtual int InterestId { get; set; }
    }
}
