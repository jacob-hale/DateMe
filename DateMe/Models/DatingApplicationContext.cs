using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class DatingApplicationContext : DbContext
    {
        public DatingApplicationContext(DbContextOptions<DatingApplicationContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Major>().HasData(
                new Major { MajorId = 1, MajorName = "Computer Science" },
                new Major { MajorId = 2, MajorName = "Business" },
                new Major { MajorId = 3, MajorName = "Education" },
                new Major { MajorId = 4, MajorName = "Engineering" },
                new Major { MajorId = 5, MajorName = "Fine Arts" },
                new Major { MajorId = 6, MajorName = "Health Sciences" },
                new Major { MajorId = 7, MajorName = "Humanities" },
                new Major { MajorId = 8, MajorName = "Mathematics" },
                new Major { MajorId = 9, MajorName = "Physical Sciences" },
                new Major { MajorId = 10, MajorName = "Social Sciences" }
            );
        }
    }
}
