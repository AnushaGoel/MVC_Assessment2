using Assessment2_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Assessment2_MVC.Context
{
    public class TrainingDbContext: DbContext
    {
        public TrainingDbContext()
        {

        }

        public TrainingDbContext(DbContextOptions<TrainingDbContext>options) : base(options) { }
        public DbSet<TrainingUser> TrainingUsers { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Request> Requests { get; set; }
        
        

    }
}
