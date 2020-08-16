namespace congresssucks_asp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using congresssucks_asp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<congresssucks_asp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(congresssucks_asp.Models.ApplicationDbContext context)
        {

        }
    }
}
