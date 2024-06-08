using System;
using System.Threading;
using System.Threading.Tasks;
using CoreCodedChatbot.Database.Context.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CoreCodedChatbot.Database.Context.Interfaces
{
    public interface IChatbotContext : IDisposable
    {
        DbSet<Setting> Settings { get; set; }
        DbSet<SongRequest> SongRequests { get; set; }
        DbSet<Song> Songs { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<SongGuessingRecord> SongGuessingRecords { get; set; }
        DbSet<SongPercentageGuess> SongPercentageGuesses { get; set; }
        DbSet<InfoCommand> InfoCommands { get; set; }
        DbSet<InfoCommandKeyword> InfoCommandKeywords { get; set; }
        DbSet<StreamStatus> StreamStatuses { get; set; }
        DbSet<LogEntry> LogEntries { get; set; }
        DbSet<Quote> Quotes { get; set; }
        DbSet<SearchSynonymRequest> SearchSynonymRequests { get; set; }
        DbSet<ModerationLog> ModerationLogs { get; set; }
        DbSet<ChannelReward> ChannelRewards { get; set; }
        DbSet<ChannelRewardRedemption> ChannelRewardRedemptions { get; set; }
        DbSet<Charter> Charters { get; set; }
        DbSet<Counter> Counters { get; set; }
        DbSet<YlylSession> YlylSessions { get; set; }
        DbSet<YlylSubmission> YlylSubmissions { get; set; }
        DbSet<YlylEntry> YlylEntries { get; set; }
        DbSet<YlylReward> YlylRewards { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity)
            where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}