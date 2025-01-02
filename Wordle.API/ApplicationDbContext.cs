using Microsoft.EntityFrameworkCore;
using Wordle.API.Configurations;
using Wordle.API.Models;

namespace Wordle.API;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Word> Words { get; set; }
    public DbSet<Game> Games { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new WordConfiguration());
        modelBuilder.ApplyConfiguration(new GameConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}