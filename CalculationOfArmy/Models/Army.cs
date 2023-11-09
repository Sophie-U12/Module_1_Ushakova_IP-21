using CalculationOfArmy.Models.UnitArmyModels;
using CalculationOfArmy.Models.UnitArmyModels.Enums;
using CalculationOfArmy.Models.UnitArmyModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationOfArmy.Models
{
    public class Army
    {
        private List<Unit> units;

        public List<Unit> Units { get => units; set => units = value; }

        public Army()
        {
            CreateArmy();
        }

        public Army(List<Unit> units)
        {
            Units = units;
        }


        private void CreateArmy()
        {
            Random random = new Random();
            Units = new List<Unit>();
            int[] countOfUnits = { random.Next(1, 10), random.Next(1, 10), random.Next(1, 10) };


            for (int i = 0; i < countOfUnits.Length; i++)
            {
                switch ((UnitType)i)
                {
                    case UnitType.Militia:
                        {
                            while (countOfUnits[i] > 0)
                            {
                                Units.Add(new Militia("Ополченець у легкій броні", 0, 5, true));
                                countOfUnits[i]--;
                            }
                        }
                        break;
                    case UnitType.Necromancer:
                        {
                            while (countOfUnits[i] > 0)
                            {
                                INecromance victim = new Militia("Ополченець у легкій броні", 0, 5, (random.Next(0, 2) == 0 ? false : true));
                                Units.Add(new Necromancer("Неромант у легкій броні", 5, 15, victim));
                                countOfUnits[i]--;
                            }
                        }
                        break;
                    case UnitType.Orcs:
                        {
                            while (countOfUnits[i] > 0)
                            {
                                INecromance victim = new Militia("Ополченець у легкій броні", 0, 5, (random.Next(0, 2) == 0 ? false : true));
                                Units.Add(new Orcs("Орк", 3, 13, victim));
                                countOfUnits[i]--;
                            }
                        }
                        break;
                }
            }
        }

        public int GetPrice()
        {
            return Units.Select(x => x.Price).Sum();
        }

        public double GetAverageSpeed()
        {
            return Units.Select(x => x.Speed).Average();
        }
    }
}
