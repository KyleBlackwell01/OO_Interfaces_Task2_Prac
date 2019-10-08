using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    public interface IWeaponData
    {
        float range { get; set; }
        int realDamage { get; set; }
    }
}
