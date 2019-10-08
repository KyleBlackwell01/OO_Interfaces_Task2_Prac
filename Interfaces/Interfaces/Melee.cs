using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Melee:Weapon
    {
        public Melee(string weaponType, int baseDamage, int baseRange, int critDamage) : base(weaponType, baseDamage, baseRange, critDamage)
        {

        }



    }
}
