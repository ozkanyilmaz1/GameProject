using GameProject.Entities;
using GameProject.PlayerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.SalesDetails
{
    public class SalesManager:ISalesService
    {
        public void Sale(Player player, Game game)
        {
            Console.WriteLine("Game: " + game.Name + " saled to : " + player.FirstName + " " + player.LastName);
        }
        public void Sale(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine("Game Name: " + game.Name + " saled to : " + player.FirstName + " " + player.LastName + " with campaign name is:  " + campaign.Name);
        }

        public void Sale(Player player, Campaign campaign)
        {
            throw new NotImplementedException();
        }

        
    }
}
