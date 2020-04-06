using System;
using System.Linq;
using CoreCodedChatbot.Database.Context.Interfaces;
using CoreCodedChatbot.Database.Context.Models;

namespace CoreCodedChatbot.Database
{
    public static class GetOrCreateUserExtension
    {
        public static User GetOrCreateUser(this IChatbotContext context, string username)
        {
            return Get(context, username) ?? Create(context, username);
        }

        private static User Get(IChatbotContext context, string username)
        {
            var user = context.Users.SingleOrDefault(u => u.Username.ToLower() == username.ToLower());

            return user;
        }

        private static User Create(IChatbotContext context, string username)
        {
            var user = new User
            {
                Username = username,
                UsedVipRequests = 0,
                UsedSuperVipRequests = 0,
                SentGiftVipRequests = 0,
                ModGivenVipRequests = 0,
                FollowVipRequest = 0,
                SubVipRequests = 0,
                DonationOrBitsVipRequests = 0,
                ReceivedGiftVipRequests = 0,
                TokenVipRequests = 0,
                TokenBytes = 0,
                TotalBitsDropped = 0,
                TotalDonated = 0,
                TimeLastInChat = DateTime.UtcNow
            };

            context.Users.Add(user);

            context.SaveChanges();

            return user;
        }
    }
}