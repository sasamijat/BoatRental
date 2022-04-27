using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BoatsMontenegro.Models;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoatsMontenegro.BaseBase
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("BaseContext")
        {
           
        }

        public DbSet<Boat> Boats  {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
       
                    
    } 
}


/*
modelBuilder.Entity<Boat>().HasKey(b => b.BoatID);    //Primary key definition 
modelBuilder.Entity<Boat>().Property(b => b.BoatID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);   //identity col

modelBuilder.Entity<User>().HasKey(u => u.UserID);    //Primary key definition 
modelBuilder.Entity<User>().Property(u => u.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);   //identity col

modelBuilder.Entity<Reservation>().HasKey(r => r.ReservationID);    //Primary key definition 
modelBuilder.Entity<Reservation>().Property(r => r.ReservationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);   //identity col

// modelBuilder.Entity<Reservation>().HasRequired(r => r.Reservation).WithMany(r => r.Reservations).HasForeignKey(r => r.Boat);  //Foreign Key
// modelBuilder.Entity<Reservation>().
//modelBuilder.Entity<Reservation>().HasRequired(r => r.Boat).WithMany(d => d.Reservations).HasForeignKey(d => new { d.BoatID });
public BaseContext() : base("BrodoviBaza")
{
    Database.SetInitializer(new BoatsMontenegroBaseInitializer());
}
public DbSet<Seller> Sellers { get; set; }
protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
}      
 public DbSet<Boat> Boats { get; set; }
 public DbSet<Buyer> Buyers { get; set; }
 public DbSet<Seller> Sellers { get; set; }
 public DbSet<Reservation> Reservations { get; set; }
 public DbSet<BoatAvailability> BoatAvaliabilites { get;set; }
 protected override void OnModelCreating(DbModelBuilder modelBuilder)
 {
     modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
 }
*/





