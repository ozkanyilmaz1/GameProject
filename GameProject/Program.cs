using GameProject.PlayerDetails;
using GameProject.SalesDetails;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new ValidationManager());
            playerManager.Add(new Player { Id = 1, FirstName = "Enis", LastName = "Işık", DateOfBirth = new DateTime(1990, 1, 6), NationalityId = "43655276468" });

            Player player = new Player
            {
                FirstName = "Smith",
                LastName = "Johnson",
                Id = 2
            };

            Player player2 = new Player
            {
                FirstName = "Elon",
                LastName = "Musk",
                Id = 3
            };

            Game game = new Game
            {
                Name = "Star Wars",
                Id = 5
            };
            Game game2 = new Game
            {
                Name = "Hitman",
                Id = 10
            };
            Campaign campaign = new Campaign
            {
                Name = "Steam Autumn Sale is Here!",
                CampaignEnd = "02.12.2021",
                DisountRate = 15
            };
            SalesManager sales = new SalesManager();
            sales.Sale(player, game);

            SalesManager sales2 = new SalesManager();
            sales2.Sale(player2, game2, campaign);
            
            

        }
    }
}
