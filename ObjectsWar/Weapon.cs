using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsWar
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public abstract Weapon CreateWeapon(Weapon weapon);
    }
    public class Tank : Weapon
    {
        public override Weapon CreateWeapon(Weapon weapon)
        {
            weapon.HitPoint = 15;
            weapon.Name = "Leopard 1A3T1";
            return weapon;
        }
    }
    public class Gun : Weapon
    {
        public override Weapon CreateWeapon(Weapon weapon)
        {
            weapon.HitPoint = 5;
            weapon.Name = "Ak-47";
            return weapon;
        }
    }
}
