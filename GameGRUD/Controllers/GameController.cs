using GameDataService;
using GameDataService.Models;
using GameDataService.MyRepository;
using GameDataService.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameGRUD.Controllers
{
    public class GameController : Controller
    {
       
        private Repository<Game> gameRepos;
        private Repository<Genre> genreRepos;
        private GameDBContext db;
        public GameController(GameDBContext context, Repository<Game> _gameRepos, Repository<Genre> _genreRepos)
        {
           
            genreRepos = _genreRepos;
            gameRepos = _gameRepos;
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetGame(Genre genre)
        {
            var all = await genreRepos.GetAll();
            genre = all.FirstOrDefault();
            GameService gameService = new GameService(db);
            var game = await gameService.GetGameByGenre(genre);
            if (game != null)
            {
                Console.WriteLine(game);
                return Json(game);
            }

            return Json("");
        }
        public void InsertGame(Game game)
        {
            if (game != null)
            {
                gameRepos.Create(game);
            }
        }
        public async void UpdateGame(Game game)
        {
            if (game != null)
            {
                gameRepos.Update(game);
            }
        }
        public void DeleteGameById(Game game)
        {
            if (game != null)
            {
                gameRepos.DeleteById(game.Id);
            }
        }
        public async Task<JsonResult> GetAllGames()
        {
           var games = await gameRepos.GetAll();
            if (games != null)
            {
                return Json(games);
            }
            return Json("");

        }
    }
}
