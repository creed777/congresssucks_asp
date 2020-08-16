namespace congresssucks_asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourceSeedData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Resources (Link, Name, Description)Values('https://www.heritage.org', 'The Heritage Foundation', 'The mission of The Heritage Foundation is to formulate and promote conservative public policies based on the principles of free enterprise, limited government, individual freedom, traditional American values, and a strong national defense.') " );

            Sql("INSERT INTO Resources ( Link, Name, Description)Values('https://www.eff.org', 'Electronic Frontier Foundation', 'The mission of The Heritage Foundation is to formulate and promote conservative public policies based on the principles of free enterprise, limited government, individual freedom, traditional American values, and a strong national defense.') ");

            Sql("INSERT INTO Resources (Link, Name, Description)Values('https://www.cato.org', 'The Cato Institute', 'The Cato Institute is a public policy research organization — a think tank — dedicated to the principles of individual liberty, limited government, free markets, and peace. Its scholars and analysts conduct independent, nonpartisan research on a wide range of policy issues.') ");

            Sql("INSERT INTO Resources (Link, Name, Description)Values('https://ari.aynrand.org', 'Ayn Rand Institute', 'ARI offers a variety of educational experiences to promote greater understanding of Ayn Rand’s philosophy and, through the writing and speaking of our experts, advocates her principles of reason, rational self-interest and laissez-faire capitalism.') ");
        }
        
        public override void Down()
        {
        }
    }
}
