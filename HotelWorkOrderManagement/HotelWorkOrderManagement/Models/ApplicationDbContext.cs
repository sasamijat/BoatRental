using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using HotelWorkOrderManagement;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace HotelWorkOrderManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<EquipmentPiece> EquipmentPieces { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DbSet<TaskStateChange> TaskStateChanges { get; set; }
        private string connectionString;


        public ApplicationDbContext(IConfiguration _configuration) : base()
        {
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                IsDeleted = false,
                Name = "Milomir",
                LastName = "Krsmanovic",
                Password = "55555",
                Username = "milomir",
                Role = User.Function.Admin
            }, new User
            {
                Id = 2,
                IsDeleted = false,
                Name = "Milica",
                LastName = "Milanovic",
                Password = "123456",
                Username = "milic@",
                Role = User.Function.Housekeeper
            },
           new User
           {
               Id = 3,
               IsDeleted = false,
               Name = "Nikola",
               LastName = "Smiljanic",
               Password = "4444",
               Username = "nikola",
               Role = User.Function.Maintainer
           });

            modelBuilder.Entity<Group>().HasData(new Group
            {
                Id = 1,
                IsDeleted = false,
                Name = "Majstori",
                Domain = "Maintaining",
                MembersCount = 2,
                SelfTaskAssign=true
            });
            modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 1,
                IsDeleted = false,
                UserId = 3,
                GroupId = 1,
                Leader = true
            });
            modelBuilder.Entity<EquipmentPiece>().HasData(new EquipmentPiece
            {
                Id = 1,
                IsDeleted = false,
                Name = "Klima",
                InstalationDate = DateTime.ParseExact("15/01/2022","dd/MM/yyyy", null),
                LastIntervention = null,
                InstalatedById = 3
            });

            modelBuilder.Entity<Task>().HasData(
            new Task
            {
                Id = 1,
                IsDeleted = false,
                Name = "Popravka Klime",
                Description = "Zamjena crijeva na klima uredjaju",
                CreatedById = 1,
                CreatedOn = DateTime.ParseExact("20/02/2022", "dd/MM/yyyy", null),
                DueDate = DateTime.Parse("23/02/2022"),
                Priority = "High",
                Status = "Active",
                Position = "304",
                Domain = "Maintaining",
                AsigneeIndividualId = null,
                AsigneeGroupId = 1,
                EquipmentToRepairId = 1,
                RepetitiveStart = null,
                RepetitiveSetting = null
            },
            new Task
            {
                Id = 2,
                IsDeleted = false,
                Name = "Pranje posteljine",
                Description = "Oprati koristenu posteljinu i postaviti novu",
                CreatedById = 1,
                CreatedOn = DateTime.Parse("15/02/2022"),
                DueDate = DateTime.Parse("18/02/2022"),
                Priority = "Normal",
                Status = "Finished",
                Position = "210",
                Domain = "HouseKeeping",
                AsigneeIndividualId = 2,
                AsigneeGroupId = null,
                EquipmentToRepairId = null,
                RepetitiveStart = null,
                RepetitiveSetting = null
            }, 
            //
            new Task
            {
                Id = 3,
                IsDeleted = false,
                Name = "Popravka Vodokotlica",
                Description = "Popraviti ili zamijeniti vodokotlic",
                CreatedById = 1,
                CreatedOn = DateTime.ParseExact("20/02/2022", "dd/MM/yyyy", null),
                DueDate = DateTime.Parse("23/02/2022"),
                Priority = "High",
                Status = "Active",
                Position = "304",
                Domain = "Maintaining",
                AsigneeIndividualId = 3,
                AsigneeGroupId = null,
                EquipmentToRepairId = 1,
                RepetitiveStart = null,
                RepetitiveSetting = null
            }, 
            new Task
            {
                Id = 4,
                IsDeleted = false,
                Name = "Zamjena sijalice",
                Description = "Zamjena pokvarene sijalice",
                CreatedById = 1,
                CreatedOn = DateTime.ParseExact("20/02/2022", "dd/MM/yyyy", null),
                DueDate = DateTime.Parse("23/02/2022"),
                Priority = "High",
                Status = "Active",
                Position = "304",
                Domain = "Maintaining",
                AsigneeIndividualId = null,
                AsigneeGroupId = 1,
                EquipmentToRepairId = 1,
                RepetitiveStart = null,
                RepetitiveSetting = null
            }
            );

            modelBuilder.Entity<Comment>().HasData(new Comment
            {
                Id = 1,
                IsDeleted = false,
                Text = "Zadatak izvrsiti sto prije",
                Created = DateTime.Parse("20/02/2022"),
                TaskID = 1,
                CreatedById = 1
            }, new Comment
            {
                Id = 2,
                IsDeleted = false,
                Text = "Uredu",
                Created = DateTime.Parse("25/02/2022"),
                TaskID = 1,
                CreatedById = 2,

            });



            modelBuilder.Entity<TaskStateChange>().HasData(new TaskStateChange
            {
                Id = 1,
                IsDeleted = false,
                Status = "Finished",
                Description= "Promjenu izvrsio po zavrsetku zadatka",
                DateOfChange = DateTime.Parse("18/02/2022"),
                TaskId = 2,
                ExecutorId = 3
            });

            modelBuilder.Entity<Task>()
               .HasOne<EquipmentPiece>(t => t.EquipmentToRepair)
               .WithMany(e => e.Tasks).
               HasForeignKey(t => t.EquipmentToRepairId).IsRequired(false);

            modelBuilder.Entity<EquipmentPiece>()
               .HasOne<User>(e => e.InstalatedBy)
               .WithMany(t => t.EquipmentPieces).
               HasForeignKey(t => t.InstalatedById).IsRequired(false);

            modelBuilder.Entity<Task>()
               .HasOne<Group>(t => t.AsigneeGroup)
               .WithMany(g => g.Tasks).
               HasForeignKey(t => t.AsigneeGroupId).IsRequired(false);

            modelBuilder.Entity<Task>()
               .HasOne<User>(t => t.AsigneeIndividual)
               .WithMany(te => te.TaskAsignees).
               HasForeignKey(t => t.AsigneeIndividualId).IsRequired(false)
               .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Comment>()
                 .HasOne<Task>(c => c.Task)
                 .WithMany(t => t.Comments)
                 .HasForeignKey(g => g.TaskID);

            modelBuilder.Entity<Task>()
                .HasOne<User>(t => t.CreatedBy)
                .WithMany(te => te.TaskCreators)
                .HasForeignKey(t => t.CreatedById).IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<TaskStateChange>()
                .HasOne<Task>(tsc => tsc.Task)
                .WithMany(t => t.TaskStateChanges)
                .HasForeignKey(tsc => tsc.TaskId);

            modelBuilder.Entity<Comment>()
                .HasOne<User>(c => c.CreatedBy)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.CreatedById);

            modelBuilder.Entity<TaskStateChange>()
                .HasOne<User>(tsc => tsc.Executor)
                .WithMany(t => t.TaskStateChanges)
                .HasForeignKey(tsc => tsc.ExecutorId);

            modelBuilder.Entity<Member>().HasKey(m => new { m.GroupId, m.UserId });



        }





    }
}
