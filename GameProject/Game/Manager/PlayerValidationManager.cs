using System;
using System.Collections.Generic;
using System.Text;
using GameProject.AbstractInterface;
namespace GameProject.Manager
{
    class PlayerValidationManager : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            if (player.DateOfBirth==2006 && player.Name=="MUHAMMET EMİN" && player.Surname=="ÇAĞLAR")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
