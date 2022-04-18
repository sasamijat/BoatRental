namespace BoatsMontenegro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        BoatID = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                        Capacity = c.Int(nullable: false),
                        Engine = c.String(),
                        FuelConsumption = c.String(),
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
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        PersonalIdNumber = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ReservedBy_UserID", "dbo.Users");
            DropForeignKey("dbo.Boats", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "Boat_BoatID", "dbo.Boats");
            DropIndex("dbo.Reservations", new[] { "ReservedBy_UserID" });
            DropIndex("dbo.Reservations", new[] { "Boat_BoatID" });
            DropIndex("dbo.Boats", new[] { "User_UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Boats");
        }
    }
}
