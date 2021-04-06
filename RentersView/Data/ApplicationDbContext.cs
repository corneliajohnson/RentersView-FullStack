using Microsoft.EntityFrameworkCore;
using RentersView.Models;

namespace RentersView.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<LeaseType> LeaseType { get; set; }
    }
}
