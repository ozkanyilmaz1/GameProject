using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.PlayerDetails
{
    internal class PlayerManager : IPlayerService
    {
        IValidationService _validationManager;

        public PlayerManager(IValidationService validationManager)
        {
            this._validationManager = validationManager;
        }
        public void Add(Player player)
        {
            if (_validationManager.Validate(player) == true)
            {
                Console.WriteLine("Player successfully registered.");
            }
            else
            {
                Console.WriteLine("Validation failed, please try again!");
            }
        }
        public void Uptade(Player player)
        {
            Console.WriteLine("Player name: " + player.FirstName + " " + player.LastName + " uptading. Please wait!");
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player name: " + player.FirstName + " " + player.LastName + " deleted. Please wait!");
        }
    }
}
