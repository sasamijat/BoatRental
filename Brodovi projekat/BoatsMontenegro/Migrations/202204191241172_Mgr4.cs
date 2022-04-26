namespace BoatsMontenegro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mgr4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ConfirmPassword");
        }
    }
}
