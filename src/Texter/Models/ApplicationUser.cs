using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Texter.Models
{
    public class ApplicationUser: IdentityUser
    {
        public virtual IEnumerable<Contact> Contacts { get; set; }
    }
}
