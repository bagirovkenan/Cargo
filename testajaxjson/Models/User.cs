using Shooping_19._01._2019.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testajaxjson.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }

}