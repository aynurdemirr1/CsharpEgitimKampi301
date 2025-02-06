using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpEgitimKampi301.EntityLayer.concrete;

namespace CsharpEgitimKampi301.DataAccessLayer.context
{
    public class KampContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<order> Orders { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
