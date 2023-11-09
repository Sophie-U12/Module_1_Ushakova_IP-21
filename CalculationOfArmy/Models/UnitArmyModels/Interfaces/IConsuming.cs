using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArmy.Models.UnitArmyModels.Interfaces
{
    public interface IConsuming
    {
        INecromance Victim { get; set; }
        void ConsumingTheVictim(INecromance victim);
    }
}
