using Microsoft.EntityFrameworkCore;
using Raceday_app.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Raceday_app.Data
{
    // Database context for the RaceDay system
    public class RaceDayContext : DbContext
    {
        public RaceDayContext(
            DbContextOptions<RaceDayContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        public DbSet<Event> Events => Set<Event>();

        public DbSet<Category> Categories => Set<Category>();

        public DbSet<RouteInfo> Routes => Set<RouteInfo>();

        public DbSet<EventImage> EventImages => Set<EventImage>();

        public DbSet<Enrolment> Enrolments => Set<Enrolment>();

        public DbSet<Result> Results => Set<Result>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .ToTable(t => t.HasCheckConstraint(
                    "CK_Users_Role",
                    "[Role] IN ('Organiser', 'Participant')"));

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organiser)
                .WithMany()
                .HasForeignKey(e => e.OrganiserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RouteInfo>()
                .HasIndex(r => r.EventId)
                .IsUnique();

            modelBuilder.Entity<Enrolment>()
                .HasIndex(e => new
                {
                    e.ParticipantId,
                    e.CategoryId
                })
                .IsUnique();

            modelBuilder.Entity<Result>()
                .HasIndex(r => r.EnrolmentId)
                .IsUnique();

            modelBuilder.Entity<Result>()
                .HasOne(r => r.Enrolment)
                .WithOne(e => e.Result)
                .HasForeignKey<Result>(r => r.EnrolmentId);
        }
    }
}