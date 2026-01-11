using BelotConsoleApp.DTOs;
using BelotConsoleApp.Data.Models;
namespace BelotConsoleApp.Services.Interfaces
{
    public interface IPlayerService
    {
        void Create(Player player);
        IEnumerable<PlayerDto> GetAll();
        void Delete(int id);
    }
}