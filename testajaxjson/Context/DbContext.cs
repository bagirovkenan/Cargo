
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using testajaxjson.Models;

namespace Shooping_19._01._2019.Context
{
    public class DbTestContext : DbContext
    {


        public DbSet<Category> Categoryes { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }

        public DbTestContext() : base("ShpConext")
        {
         
        }
    }

}