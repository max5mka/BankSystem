using Domain.Entities.Cards;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Token).IsUnique();

            builder.Property(c => c.Last4)
                .IsRequired()
                .HasMaxLength(4);

            builder.Property(c => c.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasDefaultValue(CardStatus.Active);
        }
    }
}
