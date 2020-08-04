using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class CockTailContext : DbContext
    {
        // Name= Points at the app.config file that have connection string to the sql server
        public CockTailContext() : base("name=ConnectionString")
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());

            Database.SetInitializer<CockTailContext>(new DropCreateDatabaseIfModelChanges<CockTailContext>());
        }

        public DbSet<Drink> Drinks { get; set; }
    }
}
