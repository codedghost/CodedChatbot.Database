using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class CounterMap : EntityTypeConfiguration<Counter>
    {
        public override void Map(EntityTypeBuilder<Counter> builder)
        {
            builder.ToTable("Counters");

            builder.HasKey(t => t.CounterId);

            builder.Property(t => t.CounterId)
                .HasColumnName("CounterId")
                .IsRequired();
            builder.Property(t => t.CounterName)
                .HasColumnName("CounterName")
                .IsRequired();

            builder.Property(t => t.CounterSuffix)
                .HasColumnName("CounterSuffix")
                .IsRequired();

            builder.Property(t => t.CounterValue)
                .HasColumnName("CounterValue")
                .IsRequired();
        }
    }
}