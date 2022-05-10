namespace BoatsMontenegro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationNum1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        BoatID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.String(),
                        Capacity = c.Int(nullable: false),
                        Engine = c.String(),
                        FuelConsumption = c.String(),
                        Price = c.Double(nullable: false),
                        Category = c.String(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.BoatID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        NeedCaptain = c.Boolean(nullable: false),
                        Boat_BoatID = c.Int(),
                        ReservedBy_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Boats", t => t.Boat_BoatID)
                .ForeignKey("dbo.Users", t => t.ReservedBy_UserID)
                .Index(t => t.Boat_BoatID)
                .Index(t => t.ReservedBy_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        PersonalIdNumber = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.Reservations", "ReservedBy_UserID", "dbo.Users");
            DropForeignKey("dbo.Boats", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "Boat_BoatID", "dbo.Boats");
            DropIndex("dbo.Users", new[] { "Role_RoleId" });
            DropIndex("dbo.Reservations", new[] { "ReservedBy_UserID" });
            DropIndex("dbo.Reservations", new[] { "Boat_BoatID" });
            DropIndex("dbo.Boats", new[] { "User_UserID" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Boats");
        }
    }
}
