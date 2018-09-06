using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DAL
{
    internal class MyDatabaseContext : DbContext 
    {
        public MyDatabaseContext() : base("name=AdHocDb")
        {

        }

        public DbSet<Student> Students { get; set; } 
    }
}
