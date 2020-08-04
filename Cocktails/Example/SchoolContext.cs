using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Example
{
    public class SchoolContext : DbContext
    {
        // Name= Points at the app.config file that have connection string to the sql server
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
          
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
