﻿// <auto-generated />
using CoreCodedChatbot.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoreCodedChatbot.Database.Migrations
{
    [DbContext(typeof(ChatbotContext))]
    [Migration("20180108215434_AddTokenColumnToUsers")]
    partial class AddTokenColumnToUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SettingId");

                    b.Property<string>("SettingName")
                        .IsRequired()
                        .HasColumnName("SettingName");

                    b.Property<string>("SettingValue")
                        .IsRequired()
                        .HasColumnName("SettingValue");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongId");

                    b.Property<string>("SongArtist")
                        .IsRequired()
                        .HasColumnName("SongArtist");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnName("SongName");

                    b.HasKey("SongId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.SongRequest", b =>
                {
                    b.Property<int>("SongRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SongRequestId");

                    b.Property<bool>("Played");

                    b.Property<string>("RequestText");

                    b.Property<DateTime>("RequestTime");

                    b.Property<string>("RequestUsername")
                        .IsRequired()
                        .HasColumnName("RequestUsername")
                        .HasMaxLength(255);

                    b.Property<int>("SongId")
                        .HasColumnName("SongId");

                    b.Property<DateTime?>("VipRequestTime");

                    b.HasKey("SongRequestId");

                    b.ToTable("SongRequests");
                });

            modelBuilder.Entity("CoreCodedChatbot.Database.Context.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnName("Username");

                    b.Property<int>("DonationOrBitsVipRequests")
                        .HasColumnName("DonationOrBitsVipRequests");

                    b.Property<int>("FollowVipRequest")
                        .HasColumnName("FollowVipRequest");

                    b.Property<int>("ModGivenVipRequests")
                        .HasColumnName("ModGivenVipRequests");

                    b.Property<int>("SubVipRequests")
                        .HasColumnName("SubVipRequests");

                    b.Property<int>("TokenBytes");

                    b.Property<int>("UsedVipRequests")
                        .HasColumnName("UsedVipRequests");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
