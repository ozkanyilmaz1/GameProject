using GameProject.PlayerDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public interface IValidationService
    {
        bool Validate(Player player);
    }
}
