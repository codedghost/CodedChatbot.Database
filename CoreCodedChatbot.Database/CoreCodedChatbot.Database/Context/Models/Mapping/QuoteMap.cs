using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class QuoteMap : EntityTypeConfiguration<Quote>
    {
        public override void Map(EntityTypeBuilder<Quote> builder)
        {
            builder.ToTable("Quotes");

            builder.HasKey(t => t.QuoteId);

            builder.Property(t => t.QuoteId).HasColumnName("QuoteId").IsRequired();
            builder.Property(t => t.QuoteText).HasColumnName("QuoteText").IsRequired();
            builder.Property(t => t.LastEdited).HasColumnName("LastEdited").IsRequired();
            builder.Property(t => t.CreatedBy).HasColumnName("CreatedBy").IsRequired();
            builder.Property(t => t.Enabled).HasColumnName("Enabled").IsRequired();
            builder.Property(t => t.LastEditedBy).HasColumnName("LastEditedBy");
        }
    }
}