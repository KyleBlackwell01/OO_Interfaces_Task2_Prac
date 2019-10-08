using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Weapon
    {
        public string weaponType;
        public int baseDamage;
        public int baseRange;
        public int critDamage;

        public Weapon(string weaponType, int baseDamage, int baseRange, int critDamage)
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
