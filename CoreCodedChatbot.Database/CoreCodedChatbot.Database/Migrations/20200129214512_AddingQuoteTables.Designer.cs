﻿// <auto-generated />
using System;
using CoreCodedChatbot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCodedChatbot.Database.Migrations
{
    [DbContext(typeof(ChatbotContext))]
    [Migration("20200129214512_AddingQuoteTables")]
    partial class AddingQuoteTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.InfoCommand", b =>
                {
                    b.Property<int>("InfoCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InfoCommandId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("QuoteText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
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

                    b.Property<string>("SongArtist")
                        .IsRequired()
                        .HasColumnName("SongArtist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnName("SongName")
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

                    b.Property<int>("SongId")
                        .HasColumnName("SongId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SuperVipRequestTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VipRequestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("SongRequestId");

                    b.ToTable("SongRequests");
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

                    b.HasKey("Username");

                    b.ToTable("Users");
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
#pragma warning restore 612, 618
        }
    }
}
