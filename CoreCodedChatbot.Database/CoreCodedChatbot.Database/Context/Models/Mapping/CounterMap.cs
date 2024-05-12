using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class CounterMap : EntityTypeConfiguration<Counter>
    {
        public override void Map(EntityTypeBuilder<Counter> builder)
        {
            builder.ToTable("Counters");

            builder.HasKey(t => t.CounterName);

            builder.Property(t => t.CounterName)
                .HasColumnName("CounterName")
                .IsRequired();

            builder.Property(t => t.CounterSuffix)
                .HasColumnName("CounterSuffix")
                .IsRequired();

            builder.Property(t => t.CounterValue)
                .HasColumnName("CounterValue")
                .IsRequired();

            builder.Property(t => t.Archived)
                .HasColumnName("Archived")
                .IsRequired();
        }
    }
}