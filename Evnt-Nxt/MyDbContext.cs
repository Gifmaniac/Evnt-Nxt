using Microsoft.EntityFrameworkCore;

namespace Evnt_Nxt
{
    public class MyDbContext : DbContext
    {
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }


    }
}
