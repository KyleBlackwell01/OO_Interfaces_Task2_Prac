using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    public class Melee : Weapon, IWeaponData
    {
        private Random random = new Random();
        int chance;
        public Melee(string weaponType, int baseDamage, float baseRange, float critDamage) : base(weaponType, baseDamage, baseRange, critDamage)
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

        public int meleeDamage(int baseDamage, float baseRange, int chance)
        {
            if(range > baseRange+85)
            {
                return baseDamage = 0;
            }
            else if (range < baseRange + 50)
            {
                return baseDamage = 12;
            }
            else
            {
                return baseDamage = 10;
            }
        }

        public int randomChance(int chance)
        {
            return chance = random.Next(0, 100);
        }

        public int CritDamage(int baseDamage, int chance)
        {
            if (chance == 2)
            {
                return baseDamage = baseDamage * 2;
            }
            else
            {
                return baseDamage = baseDamage;
            }
        }

    }
}
