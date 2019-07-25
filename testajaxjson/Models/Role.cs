using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testajaxjson.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}