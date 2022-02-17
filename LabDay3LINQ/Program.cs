using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //context
            Context context = new Context();

            Database.SetInitializer<Context>(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());
            // Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());

            Department department = new Department() { ID = 1,Name="it"};
            context.Departments.Add(department);
            context.SaveChanges();
        }
    }
}
