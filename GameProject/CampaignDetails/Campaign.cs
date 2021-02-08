using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
        public string CampaignEnd { get; set; }
        public int DisountRate { get; internal set; }
    }
}
