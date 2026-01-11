using System.ComponentModel.DataAnnotations;
namespace BelotConsoleApp.Data.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = null!;
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
    }
}