namespace Wordle.API.Models;

public class Game
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public Guid WordId { get; set; }
    public Word? Word { get; set; }
    public int Attempts { get; set; }
    public DateTime? WinAt { get; set; } = null;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}