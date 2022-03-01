using GameDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataService.Interfaces
{
    public interface IGameService
    {
        public Task<IEnumerable<Game>> GetGameByGenre(Genre genre);
    }
}
