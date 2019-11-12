using System;
using System.IO;
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

        private IConfigurationRoot ConfigRoot { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true);

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
        }
    }
}
