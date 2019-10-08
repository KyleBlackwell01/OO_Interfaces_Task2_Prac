using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IWeaponData
    {
        int baseDamage { get; set; }
        int baseRange { get; set; }
        int critDamage { get; set; }
        string weaponType { get; set; }
        


    }
}
