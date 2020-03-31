using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreCodedChatbot.Database.Context.Models.Mapping
{
    public class SearchSynonymRequestMap : EntityTypeConfiguration<SearchSynonymRequest>
    {
        public override void Map(EntityTypeBuilder<SearchSynonymRequest> builder)
        {
            builder.ToTable("SearchSynonymRequests");

            builder.HasKey(t => t.SearchSynonymRequestId);
            builder.Property(t => t.SearchSynonymRequestId).HasColumnName("SearchSynonymRequestId").IsRequired();

            builder.Property(t => t.SynonymRequest).IsRequired();
            builder.Property(t => t.Username).IsRequired();
        }
    }
}