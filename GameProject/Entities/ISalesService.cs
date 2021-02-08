using GameProject.PlayerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public interface ISalesService
    {
        void Sale(Player player, Game game);
        void Sale(Player player, Campaign campaign);
    }
}
