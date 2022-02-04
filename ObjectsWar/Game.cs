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
            var winner = Battle(myArmy, enemy);
            return winner;
        }

        private static Army Battle(Army myArmy, Army enemy)
        {           
            while (myArmy.Soldiers.Count > 0 && enemy.Soldiers.Count > 0)
            {
                var mySoldiers = myArmy.Soldiers;
                var enemySoldiers = enemy.Soldiers;
                int i = 0;
                ClashTheSoldiers(mySoldiers, enemySoldiers, i);
                RemoveDeadSoldier(mySoldiers, enemySoldiers, i);
            }
            return myArmy.Soldiers.Count > 0 ? myArmy : enemy;
        }

        private static void ClashTheSoldiers(List<Soldier> mySoldiers, List<Soldier> enemySoldiers, int i)
        {
            while (enemySoldiers[i].Health > 0 && mySoldiers[i].Health > 0)
            {
                enemySoldiers[i].Health -= mySoldiers[i].Weapon.HitPoint;
                mySoldiers[i].Health = (mySoldiers[i].Armor + mySoldiers[i].Health) - enemySoldiers[i].Weapon.HitPoint;
            }
        }

        private static void RemoveDeadSoldier(List<Soldier> mySoldiers, List<Soldier> enemySoldiers, int i)
        {
            if (mySoldiers[i].Health > enemySoldiers[i].Health)
            {
                enemySoldiers.Remove(enemySoldiers[i]);
                if (enemySoldiers.Count > 0)
                {
                    enemySoldiers[i].Health = 100;
                }
            }
            else
            {
                mySoldiers.Remove(mySoldiers[i]);
                if (mySoldiers.Count > 0)
                {
                    mySoldiers[i].Health = 100;
                }
            }
        }

    }
}
