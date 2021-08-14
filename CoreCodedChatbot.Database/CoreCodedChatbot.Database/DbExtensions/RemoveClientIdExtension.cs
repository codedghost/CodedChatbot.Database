using System.Linq;
using CoreCodedChatbot.Database.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreCodedChatbot.Database.DbExtensions
{
    public static class RemoveClientIdExtension
    {
        public static void RemoveClientId(this DbSet<User> users, string hubType, string clientId)
        {
            var user = users.SingleOrDefault(u => u._clientIds.Contains(clientId));

            if (user == null) return;

            var clientIds = user.GetClientIdsDictionary();
            if (clientIds.Any() && clientIds.ContainsKey(hubType))
            {
                clientIds[hubType].Remove(clientId);
            }

            user.UpdateClientIdsDictionary(clientIds);
        }
    }
}