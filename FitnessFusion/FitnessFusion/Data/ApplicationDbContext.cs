using FitnessFusion.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessFusion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Parameters> Parameters { get; set; }
        public DbSet<CardioParameters> CardioParameters { get; set; }
        public DbSet<StrengthParameters> StrengthParameters { get; set; }
        public DbSet<HybridParameters> HybridParameters { get; set; }
        public DbSet<ParametersChoice> ParametersChoice { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<GymProgram> GymProgram { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<ExtraGymSession> ExtraGymSessions { get; set; }
        public DbSet<GymActivity> GymActivity { get; set; }

        // Table names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Trainer>().ToTable("Trainers");
            modelBuilder.Entity<CardioParameters>().ToTable("CardioParameters");
            modelBuilder.Entity<StrengthParameters>().ToTable("StrengthParameters");
            modelBuilder.Entity<HybridParameters>().ToTable("HybridParameters");
            modelBuilder.Entity<ParametersChoice>().ToTable("ParametersChoices");
            modelBuilder.Entity<CreditCard>().ToTable("CreditCards");
            modelBuilder.Entity<Schedule>().ToTable("Schedules");
            modelBuilder.Entity<Result>().ToTable("Results");
            modelBuilder.Entity<GymProgram>().ToTable("GymPrograms");
            modelBuilder.Entity<Training>().ToTable("Trainings");
            modelBuilder.Entity<ExtraGymSession>().ToTable("ExtraGymSessions");
            modelBuilder.Entity<GymActivity>().ToTable("GymActivities");
            base.OnModelCreating(modelBuilder);
        }

    }
}
