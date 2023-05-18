using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nagarro.EventManagement.Shared;
using System;

namespace Nagarro.EventManagement.EntityDataModel
{
    public class BookEventContext : IdentityDbContext<ApplicationUser>
    {

        public BookEventContext(DbContextOptions<BookEventContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Comments> Comments { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>().HasData(new Event { EventId = 1, Title = "Default", Date = DateTime.Now, Location = "Default", StartTime = new TimeSpan(12, 12, 12), Type = false, DurationInHours = 1, Description = "", OtherDetails = "", InviteByEmails = "", EventCreatedByEmail = "myadmin@bookevents.com", Comments = null });

            modelBuilder.Entity<Comments>().HasData(new Comments { CommentID=1, Commentor="myadmin@bookevents.com",Message="good!",EventId=1});
        }
    }
}
