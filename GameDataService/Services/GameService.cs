using GameDataService.Interfaces;
using GameDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameDataService.Services
{
    public class GameService : IGameService
    {
       public readonly DbContext db;
       public GameService(DbContext _context)
        {
            db = _context;
        }
        public Task<IEnumerable<Game>> GetGameByGenre(Genre genre)
        {
            
            var allGames = db.Set<Game>().ToList();
            var games = allGames.Where(x => x.Genre == genre);
            if (games != null)
            {
                return Task.FromResult(games);
            }
            return Task.FromResult<IEnumerable<Game>>(null);
        }
    }
}
