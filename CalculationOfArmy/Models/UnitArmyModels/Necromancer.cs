using CalculationOfArmy.Models.UnitArmyModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArmy.Models.UnitArmyModels
{
    public class Necromancer : Unit, IConsuming
    {
        private INecromance victim;
        public INecromance Victim { get => victim; set => victim = value; }

        public Necromancer() : base()
        {

            Price = 5;
            Speed = 15;
            Victim = null;
        }

        public Necromancer(string name, int price, int speed, INecromance victim) : base(name, price, speed)
        { 
            ConsumingTheVictim(victim);
        }

        public void ConsumingTheVictim(INecromance victim)
        {
            if (victim != null && victim.GetType() == typeof(Militia))
            {
                Victim = victim;
                var vict = victim as Militia;
                Price += vict.IsAlive ? 1 : 0;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Жертва: " +
                $"{(Victim != null && Victim.GetType() == typeof(Militia) ? (((Militia)Victim).IsAlive ? "Жива" : "Мертва") : "-")}.";
        }
    }
}
