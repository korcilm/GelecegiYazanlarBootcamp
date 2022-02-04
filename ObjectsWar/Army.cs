using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsWar
{
    public class Army
    {
        public string Name { get; set; }
        public int TotalHealth { get; set; }
        public int TotalHitPoint { get; set; }
        public List<Soldier> Soldiers { get; set; }
        public List<Soldier> ProduceSoldiers(int tankmanCount,int rankerCount)
        {
            List<Soldier> soldiers = new List<Soldier>();
            Soldier tankman = new Tankman();
            Soldier ranker = new Ranker();
            CreateSoldier(tankmanCount,soldiers, tankman);
            CreateSoldier(rankerCount,soldiers, ranker);
          
            return soldiers;
        }

        private static void CreateSoldier(int tankmanCount, List<Soldier> soldiers, Soldier soldier)
        {
            while (tankmanCount > 0)
            {
                soldier.BeArmedSoldier(soldier);
                soldiers.Add(soldier);
                tankmanCount--;
            }
        }
    }
}
