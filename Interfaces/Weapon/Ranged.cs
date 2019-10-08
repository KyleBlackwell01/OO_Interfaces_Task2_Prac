using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    public class Ranged : Weapon, ICloseRange, IWeaponData
    {
        Random random = new Random();
        int rchance = 0;
        public Ranged(string weaponType, int baseDamage, float baseRange, int critDamage) : base(weaponType, baseDamage, baseRange, critDamage)
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

        public float closeRange
        {
            get { return closeRange; }
            set { closeRange = value; }
        }

        public int rangedDamage(int baseDamage, float baseRange)
        {
            if (range > baseRange)
            {
                return baseDamage = 0;
            }
            else
            {
                return baseDamage = random.Next(5, 10);
            }
        }

        public int closeRangedDamage(int baseDamage, float closeRange, int rchance)
        {
            if(range != closeRange)
            {
                return baseDamage = 0;
            }
            else
            {
                if(rchance == 2)
                {
                    return baseDamage = 10 * 2;
                }
                else
                {
                    return baseDamage = 10;
                }
            }
        }

        public int randomChance(int rchance)
        {
            return rchance = random.Next(0, 100);
        }

        public int CritDamage(int baseDamage, int rchance, float range, float baseRange)
        {
            if(range <= baseRange + 75)
            {
                if (rchance == 1)
                {
                    return baseDamage = baseDamage * 2;
                }
                else
                {
                    return baseDamage;
                }
            }
            else
            {
                return baseDamage;
            }

        }

    }
}
