using System;
using System.Linq;
using CoreCodedChatbot.Database.Context.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using CoreCodedChatbot.Database.Context.Models;
using CoreCodedChatbot.Database.Context.Models.Mapping;
using CoreCodedChatbot.Secrets;

namespace CoreCodedChatbot.Database.Context
{
    public class ChatbotContext : DbContext, IChatbotContext
    {
        private readonly ISecretService _secretService;

        public ChatbotContext()
            : base()
        {

        }

        public ChatbotContext(ISecretService secretService)
            : base()
        {
            _secretService = secretService;
        }

        public ChatbotContext(DbContextOptions<ChatbotContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<SongRequest> SongRequests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SongGuessingRecord> SongGuessingRecords { get; set; }
        public DbSet<SongPercentageGuess> SongPercentageGuesses { get; set; }
        public DbSet<InfoCommand> InfoCommands { get; set; }
        public DbSet<InfoCommandKeyword> InfoCommandKeywords { get; set; }
        public DbSet<StreamStatus> StreamStatuses { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<SearchSynonymRequest> SearchSynonymRequests { get; set; }
        public DbSet<ModerationLog> ModerationLogs { get; set; }
        public DbSet<ChannelReward> ChannelRewards { get; set; }
        public DbSet<ChannelRewardRedemption> ChannelRewardRedemptions { get; set; }
        public DbSet<Charter> Charters { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<YlylSession> YlylSessions { get; set; }
        public DbSet<YlylSubmission> YlylSubmissions { get; set; }
        public DbSet<YlylEntry> YlylEntries { get; set; }
        public DbSet<YlylReward> YlylRewards { get; set; }

        private IConfigurationRoot ConfigRoot { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

            ConfigRoot = builder.Build();

            var connectionString = ConfigRoot["DbConnectionString"];

            if (!ConfigRoot.AsEnumerable().Any(c =>
                string.Equals(c.Key, "DbConnectionString", StringComparison.InvariantCultureIgnoreCase)))
            {
                connectionString = _secretService.GetSecret<string>("DbConnectionString");
            }

            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new SongMap());
            modelBuilder.AddConfiguration(new SongRequestMap());
            modelBuilder.AddConfiguration(new UserMap());
            modelBuilder.AddConfiguration(new SettingMap());
            modelBuilder.AddConfiguration(new SongGuessingRecordMap());
            modelBuilder.AddConfiguration(new SongPercentageGuessMap());
            modelBuilder.AddConfiguration(new InfoCommandMap());
            modelBuilder.AddConfiguration(new InfoCommandKeywordMap());
            modelBuilder.AddConfiguration(new StreamStatusMap());
            modelBuilder.AddConfiguration(new LogEntryMap());
            modelBuilder.AddConfiguration(new SearchSynonymRequestMap());
            modelBuilder.AddConfiguration(new ModerationLogMap());
            modelBuilder.AddConfiguration(new ChannelRewardMap());
            modelBuilder.AddConfiguration(new ChannelRewardRedemptionMap());
            modelBuilder.AddConfiguration(new CharterMap());
            modelBuilder.AddConfiguration(new CounterMap());
            modelBuilder.AddConfiguration(new YlylSessionMap());
            modelBuilder.AddConfiguration(new YlylSubmissionMap());
            modelBuilder.AddConfiguration(new YlylEntryMap());
            modelBuilder.AddConfiguration(new YlylRewardMap());
        }
    }
}
