using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;

namespace IO.Swagger
{
    /// <summary>
    /// Application DB context :)
    /// </summary>
    public class ApplicationDbContext: DbContext
    {
        /// <summary>
        /// Feedback table
        /// </summary>
        public DbSet<Feedback> Feedback { get; set; }
        /// <summary>
        /// Events table
        /// </summary>
        public DbSet<Event> Events { get; set; }
        
        /// <inheritdoc />
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>()
                .HasKey(c => new { c.Id, c.EventId });
        }
    }
}