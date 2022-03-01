
using GameDataService.Models;
using Microsoft.EntityFrameworkCore;

namespace GameDataService
{
    public class GameDBContext: DbContext
    {
        DbSet<Genre> Genres { get; set; }
        DbSet<Game> Games { get; set; }

       public GameDBContext(DbContextOptions<GameDBContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Genre action = new Genre() { Name = "Action" };
            Genre rouglike = new Genre() { Name = "Rouglike" };
            Genre Arcade = new Genre() { Name = "Arcade" };


            Game gungeon = new Game() { Name = "Enter The Gungeon", Company = "Devolver", Genre =  rouglike};
            Game mario = new Game() { Name = "Mario", Company = "Nintendo", Genre = Arcade };
            Game marioAction = new Game() { Name = "Mario", Company = "Nintendo", Genre = action };







            Genres.AddRange(action, rouglike, Arcade);
            Games.AddRange(gungeon , mario ,marioAction);
            SaveChanges();


            
        }
    }
}