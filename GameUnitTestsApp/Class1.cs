
using GameDataService;
using GameDataService.Models;
using GameDataService.MyRepository;
using GameDataService.Services;
using GameGRUD.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
namespace GameUnitTestsApp
{
    public class GameControllerTests
    {
        private GameDBContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<GameDBContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString("N")).Options;
            var dbContext = new GameDBContext(options);
            return dbContext;
        }

        [Fact]
        public async void GameController_GetGame_()
        {

            var mockDbContext = CreateDbContext();


           var mockGameRepos = new ImplementRepos<Game>(mockDbContext);

            var result = mockGameRepos.GetAll();

            

            //var TaskResult = Assert.IsType<Task<IEnumerable<Game>>>(result);
            var data = await result;
            Assert.True(data.Count() > 0);
            mockDbContext.Dispose();
        }
        [Fact]
        public async void GameService_GetGameByGerne()
        {
            var mockDb = CreateDbContext();


            var hard = new Genre() { Name = "Сложная" };
            var arcade = new Genre() { Name = "Arcade" };
           

            var Games = new List<Game>()
            {
                new Game(){Id = 200, Name = "DarkSouls" , Company = "N-Space" , Genre = hard},
                new Game(){Id = 201, Name = "Mario" , Company = "Nintendo" , Genre = arcade}
            };

            mockDb.Set<Genre>().AddRange(hard,arcade);
            mockDb.Set<Game>().AddRange(Games);
            mockDb.SaveChanges();
            var service = new GameService(mockDb);

            var result = await service.GetGameByGenre(hard);
            
            Assert.True(result.Count()==1);
            mockDb.Dispose();
        }
        [Fact]
        public async void UpdateTest()
        {
            var mockDb = CreateDbContext();


            var hard = new Genre() { Name = "Сложная" };



            var Game = new Game() {  Id = 202 ,Name = "DarkSouls", Company = "N-Space", Genre = hard };
                
            

            mockDb.Set<Genre>().AddRange(hard);
            mockDb.Set<Game>().AddRange(Game);
            mockDb.SaveChanges();
            var repos = new ImplementRepos<Game>(mockDb);

           var gamebefore = await repos.GetById(Game.Id);
            gamebefore.Name = "QQQ";
            
            repos.Update(gamebefore);
            
            var result = await repos.GetById(Game.Id);
            
            Assert.True(result.Name =="QQQ");
            mockDb.Dispose();
        }
        [Fact]
        public async void DeleteTest()
        {
            var mockDb = CreateDbContext();


            var hard = new Genre() { Name = "Сложная" };



            var Game = new Game() { Id = 202, Name = "DarkSouls", Company = "N-Space", Genre = hard };



            mockDb.Set<Genre>().AddRange(hard);
            mockDb.Set<Game>().AddRange(Game);
            mockDb.SaveChanges();
            
            var repos = new ImplementRepos<Game>(mockDb);
            var games = await repos.GetAll();
            var gamesCountBefore = games.Count();

            repos.DeleteById(Game.Id);

             games = await repos.GetAll();
            var gamesCountAfter = games.Count();



            Assert.True(gamesCountBefore > gamesCountAfter);
        }
        [Fact]
        public async void InsertTest()
        {
            var mockDb = CreateDbContext();


            var hard = new Genre() { Name = "Сложная" };



            var Game = new Game() { Id = 202, Name = "DarkSouls", Company = "N-Space", Genre = hard };



            mockDb.Set<Genre>().AddRange(hard);
           

            var repos = new ImplementRepos<Game>(mockDb);
            var games = await repos.GetAll();
            var gamesCountBefore = games.Count();

            repos.Create(Game);

            games = await repos.GetAll();
            var gamesCountAfter = games.Count();



            Assert.True(gamesCountBefore < gamesCountAfter);
        }

    }
}