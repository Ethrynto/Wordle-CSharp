namespace Wordle.API.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public string? Email { get; set; }
    public required string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}