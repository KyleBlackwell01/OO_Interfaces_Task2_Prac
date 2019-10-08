using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    public class Weapon
    {
        public string weaponType;
        public int baseDamage;
        public float baseRange;
        public float critDamage;

        public Weapon(string weaponType, int baseDamage, float baseRange, float critDamage)
        {
            this.weaponType = weaponType;
            this.baseDamage = baseDamage;
            this.baseRange = baseRange;
            this.critDamage = critDamage;
        }

        public void poke()
        {
            baseDamage = 1;
        }


    }
}
