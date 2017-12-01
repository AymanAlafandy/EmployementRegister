namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using EmployeeRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccessLayer.RegisterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Employees.AddOrUpdate(x => x.FirstName, new Employee()
            {
                FirstName = "Moshen",
                LastName = "Bukenya",
                Salary = 23000,
                Position = "developer",
                Department = "IT"
            });
        }
    }
}
