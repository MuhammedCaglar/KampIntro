using System;
using System.Collections.Generic;
using System.Text;
using GameProject.AbstractInterface;

namespace GameProject.AbstractInterface
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
