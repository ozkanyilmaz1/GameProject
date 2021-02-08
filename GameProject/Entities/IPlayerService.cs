using GameProject.PlayerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Uptade(Player player);
        void Delete(Player player);
    }
}
