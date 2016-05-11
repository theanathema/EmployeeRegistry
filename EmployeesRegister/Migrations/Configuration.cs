namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeesRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            context.Employees.AddOrUpdate(
                p => p.LastName,
                    new Employee { FirstName = "Peter", LastName = "Fredriksson", Salary = 30000, Position = "CTO", Department = "IT", Company = "Microsoft" },
                    new Employee { FirstName = "Daniel", LastName = "Åström", Salary = 25000, Position = "CEO", Department = "Economy", Company = "ID Software" }
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
