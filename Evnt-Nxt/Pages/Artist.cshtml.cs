using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Evnt_Nxt.Pages
{
    public class ArtistModel : PageModel
    {
        private readonly MyDbContext Context;

        
        [BindProperty]
        public Artist NewArtist { get; set; }
        public Genre NewGenre { get; set; }
        public List<Artist> Artist { get; set; }= new List<Artist>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<(string ArtistName, string GenreName)> ArtistGenreList { get; set; } = new();

        public ArtistModel(MyDbContext context)
        {
            Context = context;
        }

        public void OnGet()
        {
            Artist = Context.Artist.ToList();
            Genres = Context.Genre.ToList();
            //ArtistGenreList = Context.ArtistGenres.ToList();

        }

        public Microsoft.AspNetCore.Mvc.IActionResult OnPost()
        {
            Context.Artist.Add(NewArtist);
            Context.GenreList.Add(NewGenre);
            Context.SaveChanges();
            return RedirectToPage();
        }
    }
}
