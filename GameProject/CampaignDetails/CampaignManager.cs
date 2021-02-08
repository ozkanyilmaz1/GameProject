using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully added:  " + campaign.Name);
        }
        public void Uptade(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully uptaded: " + campaign);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted: " + campaign);
        }
    }
}
