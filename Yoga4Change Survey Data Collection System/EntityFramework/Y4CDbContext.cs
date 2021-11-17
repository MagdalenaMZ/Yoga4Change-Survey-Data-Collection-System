using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


       /* public DbSet<Question> Questions
        {

        }
       */
    }
}
