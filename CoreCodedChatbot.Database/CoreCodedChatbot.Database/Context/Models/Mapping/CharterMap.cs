using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class CharterMap : EntityTypeConfiguration<Charter>
    {
        public override void Map(EntityTypeBuilder<Charter> builder)
        {
            builder.ToTable("Charters");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
            builder.Property(t => t.Preferred).HasColumnName("Preferred").IsRequired().HasDefaultValue(false);

            builder.HasMany(t => t.Songs).WithOne(o => o.Charter).HasForeignKey(o => o.CharterId);
        }
    }
}