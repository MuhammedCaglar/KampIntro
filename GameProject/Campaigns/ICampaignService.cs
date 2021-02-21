using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Sale;
namespace GameProject.Campaigns
{
    interface ICampaignService
    {
        void Add(Campaign campaign, Game game);
        void Delete(Campaign campaign, Game game);
        void Update(Campaign campaign, Game game);
    }
}
