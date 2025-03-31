using Microsoft.EntityFrameworkCore;

namespace Evnt_Nxt
{
    public class MyDbContext : DbContext
    {
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<ArtistGenre> ArtistGenres { get; set; }
        public List<Artist> ArtistList { get; set; } = new List<Artist>();
        public List<Genre> GenreList { get; set; } = new List<Genre>();

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }


    }
}
