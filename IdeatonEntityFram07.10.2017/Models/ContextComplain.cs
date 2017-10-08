using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdeatonEntityFram07._10._2017.Models
{
    public class ContextComplain : DbContext
    {
        public ContextComplain() : base("ComplainContext") { }

        public DbSet<RootObject> ComplanDB { get; set; }
    }
}