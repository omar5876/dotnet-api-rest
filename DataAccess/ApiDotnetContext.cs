using backendDotnet.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace backendDotnet.DataAccess
{
    public class ApiDotnetContext: DbContext
    {
        public ApiDotnetContext(DbContextOptions<ApiDotnetContext> options): base(options)
        {
        }

        //Tables of our DB

        public DbSet<User>? User { get; set; }
        public DbSet<Course>? Course { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
