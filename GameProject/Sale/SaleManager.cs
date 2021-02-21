using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Campaigns;
using GameProject.Sale;
namespace GameProject.Sale
{
    class SaleManager : ISaleService
    {
        

        public void CampaignSales(Player player, Game game, Campaign campaign)
        {
            
            Console.WriteLine(player.Name +" adlı oyuncu için " + game.GameName  + " adlı oyuna " +  "%" + campaign.CampaignPercent
               + " Kadar indirim yapıldı. İndirimli Fiyat : " + game.GamePrice*campaign.CampaignPercent/100);
            
        }

        public void Sale(Player player,Game game)
        {

            Console.WriteLine(player.Name + " Adlı Oyuncuya Satıldı : " + game.GameName  +  game.GamePrice + "TL");
        }

        
    }
}
