﻿// <auto-generated />
using System;
using CoreCodedChatbot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    [DbContext(typeof(ChatbotContext))]
    partial class ChatbotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelReward", b =>
                {
                    b.Property<Guid>("ChannelRewardId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ChannelRewardId");

                    b.Property<int>("CommandType")
                        .HasColumnType("int")
                        .HasColumnName("CommandType");

                    b.Property<string>("RewardDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RewardDescription");

                    b.Property<string>("RewardTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RewardTitle");

                    b.HasKey("ChannelRewardId");

                    b.ToTable("ChannelRewards", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelRewardRedemption", b =>
                {
                    b.Property<Guid>("ChannelRewardRedemptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ChannelRewardRedemptionId");

                    b.Property<Guid>("ChannelRewardId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ChannelRewardId");

                    b.Property<bool>("Processed")
                        .HasColumnType("bit")
                        .HasColumnName("Processed");

                    b.Property<DateTime>("RedeemedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("RedeemedAt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RedeemedBy");

                    b.HasKey("ChannelRewardRedemptionId");

                    b.HasIndex("ChannelRewardId");

                    b.ToTable("ChannelRewardRedemption", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Charter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<bool>("Preferred")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Preferred");

                    b.HasKey("Id");

                    b.ToTable("Charters", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Counter", b =>
                {
                    b.Property<string>("CounterName")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CounterName");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit")
                        .HasColumnName("Archived");

                    b.Property<string>("CounterSuffix")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CounterSuffix");

                    b.Property<int>("CounterValue")
                        .HasColumnType("int")
                        .HasColumnName("CounterValue");

                    b.HasKey("CounterName");

                    b.ToTable("Counters", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommand", b =>
                {
                    b.Property<int>("InfoCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("InfoCommandId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InfoCommandId"));

                    b.Property<string>("InfoHelpText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InfoHelpText");

                    b.Property<string>("InfoText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InfoText");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.HasKey("InfoCommandId");

                    b.ToTable("InfoCommands", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommandKeyword", b =>
                {
                    b.Property<int>("InfoCommandId")
                        .HasColumnType("int")
                        .HasColumnName("InfoCommandId");

                    b.Property<string>("InfoCommandKeywordText")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("InfoCommandKeywordText");

                    b.HasKey("InfoCommandId", "InfoCommandKeywordText");

                    b.ToTable("InfoCommandKeywords", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.LogEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AppDomain")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("AppDomain");

                    b.Property<string>("Callsite")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Callsite");

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Exception");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Level");

                    b.Property<DateTime>("LoggedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("LoggedAt");

                    b.Property<string>("Logger")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Logger");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Message");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcessName");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("StackTrace");

                    b.HasKey("ID");

                    b.ToTable("LogEntry", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ModerationLog", b =>
                {
                    b.Property<int>("ModerationLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ModerationLogId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModerationLogId"));

                    b.Property<int>("Action")
                        .HasColumnType("int")
                        .HasColumnName("Action");

                    b.Property<DateTime>("ActionTakenTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("ActionTakenTime");

                    b.Property<string>("ExtraInformation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ExtraInformation");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.HasKey("ModerationLogId");

                    b.ToTable("ModerationLogs", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuoteId"));

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastEditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuoteText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SearchSynonymRequest", b =>
                {
                    b.Property<int>("SearchSynonymRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SearchSynonymRequestId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SearchSynonymRequestId"));

                    b.Property<string>("SynonymRequest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SearchSynonymRequestId");

                    b.ToTable("SearchSynonymRequests", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SettingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SettingId"));

                    b.Property<string>("SettingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SettingName");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SettingValue");

                    b.HasKey("SettingId");

                    b.ToTable("Settings", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AlbumName");

                    b.Property<int>("CFId")
                        .HasColumnType("int")
                        .HasColumnName("CFId");

                    b.Property<string>("ChartedPaths")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ChartedPaths");

                    b.Property<int>("CharterId")
                        .HasColumnType("int")
                        .HasColumnName("CharterId");

                    b.Property<bool>("IsOfficial")
                        .HasColumnType("bit")
                        .HasColumnName("IsOfficial");

                    b.Property<string>("SongArtist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SongArtist");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SongName");

                    b.Property<int>("TotalDownloads")
                        .HasColumnType("int")
                        .HasColumnName("TotalDownloads");

                    b.Property<string>("Tuning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tuning");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDateTime");

                    b.Property<DateTime>("UploadedDateTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("UploadedDateTime");

                    b.HasKey("SongId");

                    b.HasIndex("CharterId");

                    b.ToTable("Songs", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongGuessingRecord", b =>
                {
                    b.Property<int>("SongGuessingRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongGuessingRecordId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongGuessingRecordId"));

                    b.Property<decimal>("FinalPercentage")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("FinalPercentage");

                    b.Property<bool>("IsInProgress")
                        .HasColumnType("bit")
                        .HasColumnName("IsInProgress");

                    b.Property<string>("SongDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SongDetails");

                    b.Property<bool>("UsersCanGuess")
                        .HasColumnType("bit")
                        .HasColumnName("UsersCanGuess");

                    b.HasKey("SongGuessingRecordId");

                    b.ToTable("SongGuessingRecord", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongPercentageGuess", b =>
                {
                    b.Property<int>("SongPercentageGuessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongPercentageGuessId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongPercentageGuessId"));

                    b.Property<decimal>("Guess")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Guess");

                    b.Property<int>("SongGuessingRecordId")
                        .HasColumnType("int")
                        .HasColumnName("SongGuessingRecordId");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Username");

                    b.HasKey("SongPercentageGuessId");

                    b.HasIndex("SongGuessingRecordId");

                    b.ToTable("SongPercentageGuess", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongRequest", b =>
                {
                    b.Property<int>("SongRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongRequestId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongRequestId"));

                    b.Property<bool>("InDrive")
                        .HasColumnType("bit");

                    b.Property<bool>("Played")
                        .HasColumnType("bit");

                    b.Property<string>("RequestText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SongId")
                        .HasColumnType("int")
                        .HasColumnName("SongId");

                    b.Property<DateTime?>("SuperVipRequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("RequestUsername");

                    b.Property<DateTime?>("VipRequestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SongRequestId");

                    b.HasIndex("SongId");

                    b.ToTable("SongRequests", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongUrlVersion", b =>
                {
                    b.Property<int>("SongUrlVersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongUrlVersionId"));

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Version")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SongUrlVersionId");

                    b.HasIndex("SongId");

                    b.ToTable("SongUrlVersion");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.StreamStatus", b =>
                {
                    b.Property<int>("StreamStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StreamStatusId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StreamStatusId"));

                    b.Property<string>("BroadcasterUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BroadcasterUsername");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit")
                        .HasColumnName("IsOnline");

                    b.HasKey("StreamStatusId");

                    b.ToTable("StreamStatuses", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Username");

                    b.Property<int>("ChannelPointVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("ChannelPointVipRequests");

                    b.Property<int>("DonationOrBitsVipRequests")
                        .HasColumnType("int")
                        .HasColumnName("DonationOrBitsVipRequests");

                    b.Property<int>("FollowVipRequest")
                        .HasColumnType("int")
                        .HasColumnName("FollowVipRequest");

                    b.Property<int>("ModGivenVipRequests")
                        .HasColumnType("int")
                        .HasColumnName("ModGivenVipRequests");

                    b.Property<int>("ReceivedGiftVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("ReceivedGiftVipRequests");

                    b.Property<int>("SentGiftVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("SendgiftVipRequests");

                    b.Property<int>("SubVipRequests")
                        .HasColumnType("int")
                        .HasColumnName("SubVipRequests");

                    b.Property<int>("Tier2Vips")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("Tier2Vips");

                    b.Property<int>("Tier3Vips")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("Tier3Vips");

                    b.Property<DateTime>("TimeLastInChat")
                        .HasColumnType("datetime2")
                        .HasColumnName("TimeLastInChat");

                    b.Property<int>("TokenBytes")
                        .HasColumnType("int");

                    b.Property<int>("TokenVipRequests")
                        .HasColumnType("int");

                    b.Property<int>("TotalBitsDropped")
                        .HasColumnType("int")
                        .HasColumnName("TotalBitsDropped");

                    b.Property<int>("TotalDonated")
                        .HasColumnType("int")
                        .HasColumnName("TotalDonated");

                    b.Property<int>("UsedSuperVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("UsedSuperVipRequests");

                    b.Property<int>("UsedVipRequests")
                        .HasColumnType("int")
                        .HasColumnName("UsedVipRequests");

                    b.Property<int>("WatchTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("WatchTime");

                    b.Property<string>("_clientIds")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClientIds");

                    b.HasKey("Username");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylEntry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EntryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntryId"));

                    b.Property<bool>("HasReceivedReward")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("HasReceivedReward");

                    b.Property<bool>("HasWon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("HasWon");

                    b.Property<bool>("IsImage")
                        .HasColumnType("bit")
                        .HasColumnName("IsImage");

                    b.Property<int?>("YlylRewardId")
                        .HasColumnType("int")
                        .HasColumnName("YlylRewardId");

                    b.Property<int>("YlylSubmissionId")
                        .HasColumnType("int")
                        .HasColumnName("YlylSubmissionId");

                    b.HasKey("EntryId");

                    b.HasIndex("YlylSubmissionId");

                    b.ToTable("YlylEntries", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylReward", b =>
                {
                    b.Property<int>("RewardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RewardId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RewardId"));

                    b.Property<bool>("IsRedeemed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IsRedeemed");

                    b.Property<string>("RewardValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("RewardValue");

                    b.Property<int?>("YlylEntryId")
                        .HasColumnType("int")
                        .HasColumnName("YlylEntryId");

                    b.HasKey("RewardId");

                    b.HasIndex("YlylEntryId")
                        .IsUnique()
                        .HasFilter("[YlylEntryId] IS NOT NULL");

                    b.ToTable("YlylRewards", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylSession", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SessionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionId"));

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("ClosedAt");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("OpenedAt");

                    b.HasKey("SessionId");

                    b.ToTable("YlylSessions", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylSubmission", b =>
                {
                    b.Property<int>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubmissionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubmissionId"));

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnName("ChannelId");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("decimal(20,0)")
                        .HasColumnName("MessageId");

                    b.Property<int>("SessionId")
                        .HasColumnType("int")
                        .HasColumnName("SessionId");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("SubmissionTime");

                    b.Property<int>("TotalImages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("TotalImages");

                    b.Property<int>("TotalVideos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("TotalVideos");

                    b.HasKey("SubmissionId");

                    b.HasIndex("SessionId");

                    b.ToTable("YlylSubmissions", (string)null);
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelRewardRedemption", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.ChannelReward", "Reward")
                        .WithMany("Redemptions")
                        .HasForeignKey("ChannelRewardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reward");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommandKeyword", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.InfoCommand", "InfoCommand")
                        .WithMany("InfoCommandKeywords")
                        .HasForeignKey("InfoCommandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoCommand");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Song", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.Charter", "Charter")
                        .WithMany("Songs")
                        .HasForeignKey("CharterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Charter");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongPercentageGuess", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.SongGuessingRecord", "SongGuessingRecord")
                        .WithMany("SongPercentageGuesses")
                        .HasForeignKey("SongGuessingRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SongGuessingRecord");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongRequest", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.Song", "Song")
                        .WithMany("SongRequests")
                        .HasForeignKey("SongId");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongUrlVersion", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.Song", "Song")
                        .WithMany("Urls")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Song");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylEntry", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.YlylSubmission", "YlylSubmission")
                        .WithMany("YlylEntries")
                        .HasForeignKey("YlylSubmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YlylSubmission");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylReward", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.YlylEntry", "Entry")
                        .WithOne("Reward")
                        .HasForeignKey("CoreCodedChatbot.Database.Context.Models.YlylReward", "YlylEntryId");

                    b.Navigation("Entry");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylSubmission", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.YlylSession", "Session")
                        .WithMany("YlylSubmissions")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelReward", b =>
                {
                    b.Navigation("Redemptions");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Charter", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommand", b =>
                {
                    b.Navigation("InfoCommandKeywords");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Song", b =>
                {
                    b.Navigation("SongRequests");

                    b.Navigation("Urls");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongGuessingRecord", b =>
                {
                    b.Navigation("SongPercentageGuesses");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylEntry", b =>
                {
                    b.Navigation("Reward");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylSession", b =>
                {
                    b.Navigation("YlylSubmissions");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.YlylSubmission", b =>
                {
                    b.Navigation("YlylEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
