using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CoreCodedChatbot.Database.Context.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Username { get; set; }
        public int UsedVipRequests { get; set; }
        public int UsedSuperVipRequests { get; set; }
        public int SentGiftVipRequests { get; set; }
        public int ModGivenVipRequests { get; set; }
        public int FollowVipRequest { get; set; }
        public int SubVipRequests { get; set; }
        public int Tier2Vips { get; set; }
        public int Tier3Vips { get; set; }
        public int DonationOrBitsVipRequests { get; set; }
        public int ReceivedGiftVipRequests { get; set; }
        public int TokenVipRequests { get; set; }
        public int TokenBytes { get; set; }
        public int TotalBitsDropped { get; set; }
        public int TotalDonated { get; set; }
        public DateTime TimeLastInChat { get; set; }
        internal string _clientIds { get; set; }

        [NotMapped]
        public IDictionary<string, List<string>> ClientIds
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_clientIds)) return new Dictionary<string, List<string>>();

                return JsonConvert.DeserializeObject<IDictionary<string, List<string>>>(_clientIds);
            }
            set
            {
                if (value == null) _clientIds = JsonConvert.SerializeObject(new Dictionary<string, List<string>>());
                _clientIds = JsonConvert.SerializeObject(value);
            }
        }
    }
}
