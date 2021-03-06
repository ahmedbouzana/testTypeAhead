namespace testTypeHead.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Migrations.Sql;
    using System.Linq;
    using testTypeHead.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;

            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new SqlGenerator());
            CodeGenerator = new MySql.Data.EntityFramework.MySqlMigrationCodeGenerator();
            AutomaticMigrationDataLossAllowed = true;  // or false in case data loss is not allowed.
        }

        protected override void Seed(WebAppContext context)
        {
            var Customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Amine eurl",
                    IsSubscribedToNewsletter =true
                },new Customer
                {
                    Id = 2,
                    Name = "mohamed",
                    IsSubscribedToNewsletter =false
                },new Customer
                {
                    Id = 3,
                    Name = "moussa",
                    IsSubscribedToNewsletter =true
                },new Customer
                {
                    Id = 4,
                    Name = "madjid",
                    IsSubscribedToNewsletter =true
                },new Customer
                {
                    Id = 5,
                    Name = "mounir",
                    IsSubscribedToNewsletter =false
                },new Customer
                {
                    Id = 6,
                    Name = "halim amine",
                    IsSubscribedToNewsletter =true
                }
            };

            foreach (var Customer in Customers)
                context.Customers.AddOrUpdate(l => l.Id, Customer);


            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }

    class SqlGenerator : MySql.Data.EntityFramework.MySqlMigrationSqlGenerator
    {
        public override IEnumerable<MigrationStatement> Generate(IEnumerable<MigrationOperation> migrationOperations, string providerManifestToken)
        {
            IEnumerable<MigrationStatement> res = base.Generate(migrationOperations, providerManifestToken);
            foreach (MigrationStatement ms in res)
            {
                ms.Sql = ms.Sql.Replace("dbo.", "");
            }
            return res;
        }
    }
}
