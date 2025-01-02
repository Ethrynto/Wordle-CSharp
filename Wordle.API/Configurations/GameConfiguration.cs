using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wordle.API.Models;

namespace Wordle.API.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Games");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.HasOne(game => game.User)
            .WithMany()
            .HasForeignKey(game => game.UserId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasOne(game => game.Word)
            .WithMany()
            .HasForeignKey(game => game.WordId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(game => game.Attempts)
            .HasDefaultValue(1);
        
        builder.Property(game => game.WinAt)
            .HasDefaultValue(null);
    }
}