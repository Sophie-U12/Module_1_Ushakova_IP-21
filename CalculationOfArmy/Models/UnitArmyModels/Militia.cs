using CalculationOfArmy.Models.UnitArmyModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArmy.Models.UnitArmyModels
{
    public class Militia : Unit, INecromance
    {
        private bool isAlive;
        public bool IsAlive { get => isAlive; set => isAlive = value; }

        public Militia() : base()
        {
            IsAlive = true;

            Price = 0;
            Speed = 5;
        }

        public Militia(string name, int price, int speed, bool isAlive) : base(name, price, speed)
        {
            IsAlive = isAlive;
        }


        public override string ToString()
        {
            return base.ToString() + $" Чи живий?: {(IsAlive ? "Так" : "Ні")}.";
        }

    }
}
