using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsWar
{
    public class Game
    {
        public Army StartTheWar(Army myArmy, Army enemy)
        {
            CalculateHealthAndHitPoint(myArmy);
            CalculateHealthAndHitPoint(enemy);
            var winner=Battle(myArmy, enemy);

            return winner;
        }

        private static Army Battle(Army myArmy, Army enemy)
        {
            while (myArmy.TotalHealth > 0 && enemy.TotalHealth > 0)
            {
                enemy.TotalHealth -= myArmy.TotalHitPoint;
                myArmy.TotalHealth -= enemy.TotalHitPoint;
            }
            return myArmy.TotalHealth > 0 ? myArmy : enemy;
        }

        private void CalculateHealthAndHitPoint(Army army)
        {
            foreach (var soldier in army.Soldiers)
            {
                army.TotalHealth += soldier.Health + soldier.Armor;
                army.TotalHitPoint += soldier.Weapon.HitPoint;
            }
        }
    }
}
