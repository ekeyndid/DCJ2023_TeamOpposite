using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStats))]

public class PlayerCombat : MonoBehaviour
{
    public class Weapon
    {
        public string name;
        public float weaponDamage;
    }

    public float Attack (Weapon equippedWeapon)
    {
        if (PlayerStats.instance.currentCorruptionLevel < 0f)
        {
            return equippedWeapon.weaponDamage + (MathF.Abs(PlayerStats.instance.currentCorruptionLevel) + 100f / PlayerStats.instance.attackLevel);
        }
        else
        {
            return equippedWeapon.weaponDamage * (100f / PlayerStats.instance.attackLevel);
        }
        
    } 
}
