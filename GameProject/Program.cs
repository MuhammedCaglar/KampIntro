using System;
using System.Collections.Generic;
using GameProject.AbstractInterface;
using GameProject.Manager;
using GameProject.Sale;

namespace GameProject.Concreate
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            playerManager.Add(new Player { DateOfBirth = 2006, Name = "MUHAMMET EMİN", Surname = "ÇAĞLAR" });

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(new Player { Name="Muhammet Emin"}, new Game {GameName="Valheim ",GamePrice=32 });
            saleManager.CampaignSales(new Player { Name = "Muhammet Emin" }, new Game {GameName="Valheim",GamePrice=32 },
                new Campaigns.Campaign {CampaignPercent=50});


        }
    }
}
