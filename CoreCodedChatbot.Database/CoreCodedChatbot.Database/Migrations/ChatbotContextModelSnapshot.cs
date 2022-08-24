﻿// <auto-generated />
using System;
using CoreCodedChatbot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCodedChatbot.Database.Migrations
{
    [DbContext(typeof(ChatbotContext))]
    partial class ChatbotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelReward", b =>
                {
                    b.Property<Guid>("ChannelRewardId")
                        .HasColumnName("ChannelRewardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RewardDescription")
                        .IsRequired()
                        .HasColumnName("RewardDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RewardTitle")
                        .IsRequired()
                        .HasColumnName("RewardTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChannelRewardId");

                    b.ToTable("ChannelRewards");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelRewardRedemption", b =>
                {
                    b.Property<Guid>("ChannelRewardRedemptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ChannelRewardRedemptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChannelRewardId")
                        .HasColumnName("ChannelRewardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Processed")
                        .HasColumnName("Processed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RedeemedAt")
                        .HasColumnName("RedeemedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RedeemedBy")
                        .IsRequired()
                        .HasColumnName("RedeemedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChannelRewardRedemptionId");

                    b.HasIndex("ChannelRewardId");

                    b.ToTable("ChannelRewardRedemption");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommand", b =>
                {
                    b.Property<int>("InfoCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InfoCommandId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedByUser")
                        .IsRequired()
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoHelpText")
                        .IsRequired()
                        .HasColumnName("InfoHelpText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoText")
                        .IsRequired()
                        .HasColumnName("InfoText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoCommandId");

                    b.ToTable("InfoCommands");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommandKeyword", b =>
                {
                    b.Property<int>("InfoCommandId")
                        .HasColumnName("InfoCommandId")
                        .HasColumnType("int");

                    b.Property<string>("InfoCommandKeywordText")
                        .HasColumnName("InfoCommandKeywordText")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InfoCommandId", "InfoCommandKeywordText");

                    b.ToTable("InfoCommandKeywords");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.LogEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppDomain")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AppDomain")
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<string>("Callsite")
                        .HasColumnName("Callsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .HasColumnName("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnName("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LoggedAt")
                        .HasColumnName("LoggedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logger")
                        .HasColumnName("Logger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnName("ProcessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StackTrace")
                        .HasColumnName("StackTrace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LogEntry");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ModerationLog", b =>
                {
                    b.Property<int>("ModerationLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ModerationLogId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Action")
                        .HasColumnName("Action")
                        .HasColumnType("int");

                    b.Property<DateTime>("ActionTakenTime")
                        .HasColumnName("ActionTakenTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraInformation")
                        .HasColumnName("ExtraInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModerationLogId");

                    b.ToTable("ModerationLogs");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastEditedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuoteText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SearchSynonymRequest", b =>
                {
                    b.Property<int>("SearchSynonymRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SearchSynonymRequestId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SynonymRequest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SearchSynonymRequestId");

                    b.ToTable("SearchSynonymRequests");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SettingId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SettingName")
                        .IsRequired()
                        .HasColumnName("SettingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnName("SettingValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnName("AlbumName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CFId")
                        .HasColumnName("CFId")
                        .HasColumnType("int");

                    b.Property<string>("ChartedPaths")
                        .IsRequired()
                        .HasColumnName("ChartedPaths")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOfficial")
                        .HasColumnName("IsOfficial")
                        .HasColumnType("bit");

                    b.Property<string>("SongArtist")
                        .IsRequired()
                        .HasColumnName("SongArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnName("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDownloads")
                        .HasColumnName("TotalDownloads")
                        .HasColumnType("int");

                    b.Property<string>("Tuning")
                        .IsRequired()
                        .HasColumnName("Tuning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnName("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UploadedDateTime")
                        .HasColumnName("UploadedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UploaderUsername")
                        .IsRequired()
                        .HasColumnName("UploaderUsername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongGuessingRecord", b =>
                {
                    b.Property<int>("SongGuessingRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongGuessingRecordId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("FinalPercentage")
                        .HasColumnName("FinalPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsInProgress")
                        .HasColumnName("IsInProgress")
                        .HasColumnType("bit");

                    b.Property<string>("SongDetails")
                        .IsRequired()
                        .HasColumnName("SongDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UsersCanGuess")
                        .HasColumnName("UsersCanGuess")
                        .HasColumnType("bit");

                    b.HasKey("SongGuessingRecordId");

                    b.ToTable("SongGuessingRecord");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongPercentageGuess", b =>
                {
                    b.Property<int>("SongPercentageGuessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongPercentageGuessId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Guess")
                        .HasColumnName("Guess")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SongGuessingRecordId")
                        .HasColumnName("SongGuessingRecordId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongPercentageGuessId");

                    b.HasIndex("SongGuessingRecordId");

                    b.ToTable("SongPercentageGuess");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongRequest", b =>
                {
                    b.Property<int>("SongRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongRequestId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("InDrive")
                        .HasColumnType("bit");

                    b.Property<bool>("Played")
                        .HasColumnType("bit");

                    b.Property<string>("RequestText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestUsername")
                        .IsRequired()
                        .HasColumnName("RequestUsername")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("SongId")
                        .HasColumnName("SongId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SuperVipRequestTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VipRequestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SongRequestId");

                    b.HasIndex("SongId");

                    b.ToTable("SongRequests");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongUrlVersion", b =>
                {
                    b.Property<int>("SongUrlVersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnName("StreamStatusId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BroadcasterUsername")
                        .IsRequired()
                        .HasColumnName("BroadcasterUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnline")
                        .HasColumnName("IsOnline")
                        .HasColumnType("bit");

                    b.HasKey("StreamStatusId");

                    b.ToTable("StreamStatuses");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DonationOrBitsVipRequests")
                        .HasColumnName("DonationOrBitsVipRequests")
                        .HasColumnType("int");

                    b.Property<int>("FollowVipRequest")
                        .HasColumnName("FollowVipRequest")
                        .HasColumnType("int");

                    b.Property<int>("ModGivenVipRequests")
                        .HasColumnName("ModGivenVipRequests")
                        .HasColumnType("int");

                    b.Property<int>("ReceivedGiftVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ReceivedGiftVipRequests")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("SentGiftVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SendgiftVipRequests")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("SubVipRequests")
                        .HasColumnName("SubVipRequests")
                        .HasColumnType("int");

                    b.Property<int>("Tier2Vips")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Tier2Vips")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Tier3Vips")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Tier3Vips")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("TimeLastInChat")
                        .HasColumnName("TimeLastInChat")
                        .HasColumnType("datetime2");

                    b.Property<int>("TokenBytes")
                        .HasColumnType("int");

                    b.Property<int>("TokenVipRequests")
                        .HasColumnType("int");

                    b.Property<int>("TotalBitsDropped")
                        .HasColumnName("TotalBitsDropped")
                        .HasColumnType("int");

                    b.Property<int>("TotalDonated")
                        .HasColumnName("TotalDonated")
                        .HasColumnType("int");

                    b.Property<int>("UsedSuperVipRequests")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UsedSuperVipRequests")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("UsedVipRequests")
                        .HasColumnName("UsedVipRequests")
                        .HasColumnType("int");

                    b.Property<string>("_clientIds")
                        .HasColumnName("ClientIds")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.ChannelRewardRedemption", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.ChannelReward", "Reward")
                        .WithMany("Redemptions")
                        .HasForeignKey("ChannelRewardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommandKeyword", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.InfoCommand", "InfoCommand")
                        .WithMany("InfoCommandKeywords")
                        .HasForeignKey("InfoCommandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongPercentageGuess", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.SongGuessingRecord", "SongGuessingRecord")
                        .WithMany("SongPercentageGuesses")
                        .HasForeignKey("SongGuessingRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongRequest", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.Song", "Song")
                        .WithMany("SongRequests")
                        .HasForeignKey("SongId");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongUrlVersion", b =>
                {
                    b.HasOne("CoreCodedChatbot.Database.Context.Models.Song", "Song")
                        .WithMany("Urls")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
