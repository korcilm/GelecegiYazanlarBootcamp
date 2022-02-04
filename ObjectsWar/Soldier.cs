using System;

namespace ObjectsWar
{
    public abstract class Soldier
    {
        public int Health { get; set; } = 100;
        public int Armor { get; set; } = 2;
        public Weapon Weapon { get; set; }
       
        public abstract void BeArmedSoldier(Soldier soldier);
        public bool IsAlive { get; set; } = true;
    }
    public class Tankman : Soldier
    {
        public override void BeArmedSoldier(Soldier soldier)
        {
            Weapon weapon = new Tank();
            soldier.Weapon = weapon.CreateWeapon(weapon);
        }
    } 
    public class Ranker : Soldier
    {
        public override void BeArmedSoldier(Soldier soldier)
        {
            Weapon weapon = new Gun();
            soldier.Weapon = weapon.CreateWeapon(weapon);
        }
    }

}
