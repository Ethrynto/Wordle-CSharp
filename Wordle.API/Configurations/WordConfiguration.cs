using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wordle.API.Models;

namespace Wordle.API.Configurations;

public class WordConfiguration : IEntityTypeConfiguration<Word>
{
    public void Configure(EntityTypeBuilder<Word> builder)
    {
        builder.ToTable("Words");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(word => word.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(word => word.Description)
            .IsRequired();

        builder.Property(word => word.Length)
            .IsRequired();
    }
}