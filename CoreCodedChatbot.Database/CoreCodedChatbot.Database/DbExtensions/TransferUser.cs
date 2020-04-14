using System;
using System.Linq;
using CoreCodedChatbot.Database.Context.Enums;
using CoreCodedChatbot.Database.Context.Interfaces;
using CoreCodedChatbot.Database.Context.Models;

namespace CoreCodedChatbot.Database.DbExtensions
{
    public static class TransferUserExtension
    {
        public static void TransferUser(this IChatbotContext context, string moderatorUsername, string oldUsername,
            string newUsername)
        {
            var modUser = context.Users.Find(moderatorUsername);

            var oldUser = context.Users.Find(oldUsername);
            var newUser = context.Users.Find(newUsername);

            if (modUser == null || oldUser == null || newUser == null)
            {
                throw new Exception("One of the provided usernames does not exist");
            }

            TransferQuotes(context, oldUsername, newUsername);
            TransferSearchSynonymRequests(context, oldUsername, newUsername);
            TransferGuessingGameRecords(context, oldUsername, newUsername);
            TransferSongRequests(context, oldUsername, newUsername);
            TransferChatCommands(context, oldUsername, newUsername);
            TransferVipsAndBytes(context, oldUser, newUser);
            LogTransfer(context, moderatorUsername, oldUsername, newUsername);

            context.SaveChanges();
        }

        private static void TransferQuotes(IChatbotContext context, string oldUsername, string newUsername)
        {
            var quotes = context.Quotes.Where(q => q.CreatedBy == oldUsername);

            foreach (var quote in quotes)
            {
                quote.CreatedBy = newUsername;
            }
        }

        private static void TransferSearchSynonymRequests(IChatbotContext context, string oldUsername, string newUsername)
        {
            var searchSynonymRequests = context.SearchSynonymRequests.Where(ssr => ssr.Username == oldUsername);

            foreach (var searchSynonymRequest in searchSynonymRequests)
            {
                searchSynonymRequest.Username = newUsername;
            }
        }

        private static void TransferGuessingGameRecords(IChatbotContext context, string oldUsername, string newUsername)
        {
            var guessingGameRecords = context.SongPercentageGuesses.Where(spg => spg.Username == oldUsername);

            foreach (var guess in guessingGameRecords)
            {
                guess.Username = newUsername;
            }
        }

        private static void TransferSongRequests(IChatbotContext context, string oldUsername, string newUsername)
        {
            var songRequests = context.SongRequests.Where(sr => sr.RequestUsername == oldUsername);

            foreach (var songRequest in songRequests)
            {
                songRequest.RequestUsername = newUsername;
            }
        }

        private static void TransferChatCommands(IChatbotContext context, string oldUsername, string newUsername)
        {
            var commands = context.InfoCommands.Where(ic => ic.AddedByUser == oldUsername);

            foreach (var command in commands)
            {
                command.AddedByUser = newUsername;
            }
        }

        private static void TransferVipsAndBytes(IChatbotContext context, User oldUsername, User newUsername)
        {
            newUsername.UsedVipRequests += oldUsername.UsedVipRequests;
            oldUsername.UsedVipRequests = 0;

            newUsername.UsedSuperVipRequests += oldUsername.UsedSuperVipRequests;
            oldUsername.UsedSuperVipRequests = 0;

            newUsername.SentGiftVipRequests += oldUsername.SentGiftVipRequests;
            oldUsername.SentGiftVipRequests = 0;

            newUsername.ModGivenVipRequests += oldUsername.ModGivenVipRequests;
            oldUsername.ModGivenVipRequests = 0;

            newUsername.FollowVipRequest = oldUsername.FollowVipRequest;
            oldUsername.FollowVipRequest = 0;

            newUsername.SubVipRequests += oldUsername.SubVipRequests;
            oldUsername.SubVipRequests = 0;

            newUsername.DonationOrBitsVipRequests = oldUsername.DonationOrBitsVipRequests;
            oldUsername.DonationOrBitsVipRequests = 0;

            newUsername.ReceivedGiftVipRequests += oldUsername.ReceivedGiftVipRequests;
            oldUsername.ReceivedGiftVipRequests = 0;

            newUsername.TokenVipRequests += oldUsername.TokenVipRequests;
            oldUsername.TokenVipRequests = 0;

            newUsername.TokenBytes += oldUsername.TokenBytes;
            oldUsername.TokenBytes = 0;

            newUsername.TotalBitsDropped = oldUsername.TotalBitsDropped;
            oldUsername.TotalBitsDropped = 0;

            newUsername.TotalDonated += oldUsername.TotalDonated;
            oldUsername.TotalDonated = 0;
        }

        private static void LogTransfer(IChatbotContext context, string moderatorUsername, string oldUsername, string newUsername)
        {
            var logRecord = new ModerationLog
            {
                Username = moderatorUsername,
                Action = ModerationAction.UsernameTransfer,
                ActionTakenTime = DateTime.UtcNow,
                ExtraInformation = $"{moderatorUsername} has transferred {oldUsername}'s account to {newUsername}"
            };

            context.ModerationLogs.Add(logRecord);
        }
    }
}