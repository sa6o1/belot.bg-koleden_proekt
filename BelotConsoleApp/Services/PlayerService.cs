using BelotConsoleApp.Data;
using BelotConsoleApp.Data.Models;
using BelotConsoleApp.DTOs;
using BelotConsoleApp.Services.Interfaces;
namespace BelotConsoleApp.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly BelotDbContext context = new();
        public PlayerService() => context.Database.EnsureCreated();
        public void Create(Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }
        public IEnumerable<PlayerDto> GetAll() =>
            context.Players.Select(p => new PlayerDto { Username = p.Username, GamesWon = p.GamesWon }).ToList();
        public void Delete(int id)
        {
            var p = context.Players.Find(id);
            if (p != null)
            {
                context.Players.Remove(p);
                context.SaveChanges();
            }
        }
    }
}