namespace Wordle.API.Models;

public class Word
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public int Length { get; set; }
}