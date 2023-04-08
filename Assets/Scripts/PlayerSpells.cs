using System.Collections;
using System.Collections.Generic;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

[RequireComponent(typeof(PlayerStats))]

public class PlayerSpells : MonoBehaviour
{
    public class Spell
    {
        public string Name;
        public float ManaCost;
        public float SpellDamage;
    }
    
    public float CastSpell(Spell spellToCast)
    {

        if (PlayerStats.instance.currentPlayerMana > spellToCast.ManaCost)
        {
            PlayerStats.instance.CastFromMana(spellToCast.ManaCost);

            if (PlayerStats.instance.currentCorruptionLevel < 0f)
            {
                return spellToCast.SpellDamage + (100f / PlayerStats.instance.currentCorruptionLevel);
            }
            else
            {
                return spellToCast.SpellDamage;
            }
        }
        else
        {
            Debug.Log("You don't have enough mana for this spell");
            return 0f;
        }
    }
}
