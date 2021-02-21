using System;
using System.Collections.Generic;
using System.Text;
using GameProject.AbstractInterface;

namespace GameProject.Manager
{
    class PlayerManager : IPlayerService
    {

        IPlayerValidationService _playerValidationService;

        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
        }

        public void Add(Player player)
        {
            if (_playerValidationService.Validate(player)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }

            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
