using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Campaigns;
using GameProject.Sale;
namespace GameProject.Campaigns
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya" + game.GameName + " adlı oyun için eklendi " + "%" + campaign.CampaignPercent + " ile indirimde!");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya silindi." + campaign.CampaignName);
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya güncellendi." + campaign.CampaignName + " " + campaign.CampaignPercent);

        }
    }
}
