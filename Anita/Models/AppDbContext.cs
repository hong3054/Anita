using Anita.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Anita.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
            :base("anita")
        {

        }

        public DbSet<UserInfo> UserInfo { get; set; }
    }
}