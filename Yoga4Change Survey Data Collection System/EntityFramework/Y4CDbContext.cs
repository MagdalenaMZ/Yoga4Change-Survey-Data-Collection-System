using Microsoft.EntityFrameworkCore;
using Yoga4Change_Survey_Data_Collection_System.Models;

namespace Yoga4Change_Survey_Data_Collection_System.EntityFramework
{
    public class Y4CDbContext : DbContext
    {
        public Y4CDbContext(DbContextOptions<Y4CDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

         public DbSet<Response> Responses { get; set; }
       public DbSet<Question> Questions { get; set; }
    }
}
