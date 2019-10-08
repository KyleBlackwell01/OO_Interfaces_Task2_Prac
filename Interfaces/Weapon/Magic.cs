using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    public class Magic : Weapon, IWeaponData
    {



        public Magic(string weaponType, int baseDamage, float baseRange, float critDamage) : base(weaponType, baseDamage, baseRange, critDamage)
        {

        }

        public float range
        {
            get { return range; }
            set { range = value; }
        }
        public int realDamage
        {
            get { return realDamage; }
            set { realDamage = baseDamage * 2; }
        }

        public int magicDamage(int baseDamage, float baseRange)
        {
            if(range > baseRange)
            {
                return baseDamage = 0;
            }
            else
            {
                return baseDamage = 10;
            }
        }

    }
}
