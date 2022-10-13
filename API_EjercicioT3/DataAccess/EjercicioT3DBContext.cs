using API_EjercicioT3.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace API_EjercicioT3.DataAccess
{
    public class EjercicioT3DBContext : DbContext
    {
        public EjercicioT3DBContext(DbContextOptions<EjercicioT3DBContext> options) : base(options)
        {

        }

        //TODO: Add DbSets(Tables of our Data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<API_EjercicioT3.Models.DataModels.BaseEntity> BaseEntity { get; set; }

    }
}
