using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArmy.Models.UnitArmyModels
{
    public abstract class Unit
    {
        private string name;
        private int price;
        private int speed;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Speed { get => speed; set => speed = value; }


        public Unit()
        {
            Name = "";
            Price = 0;
            Speed = 0;
        }

        protected Unit(string name, int price, int speed)
        {
            Name = name;
            Price = price;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"{Name}. Ціна: ${Price}. Швидкість: {Speed} км/г.";
        }
    }
}
