using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    [SerializeField] private float currentPlayerHealth;
    [SerializeField] public float currentPlayerMana;

    [SerializeField] private float maxPlayerHealth;
    [SerializeField] private float maxPlayerMana;

    [SerializeField] public float attackLevel;
    [SerializeField] private float defenseLevel;

    [SerializeField] public float currentCorruptionLevel = 0f;
    [SerializeField] private float maxHolyCorruptionLevel = 100f;
    [SerializeField] private float maxHorrorCorruptionLevel = -100f;

    public void HealPlayer(float healAmount)
    {
        currentPlayerHealth += healAmount;

        if (currentPlayerHealth > maxPlayerHealth) currentPlayerHealth = maxPlayerHealth;
    }

    public void RestoreMana(float manaRestoreAmount)
    {
        currentPlayerMana += manaRestoreAmount;

        if (currentPlayerMana > maxPlayerMana) currentPlayerMana = maxPlayerMana;
    }

    public void DamagePlayer(float damageAmount)
    {
        currentPlayerHealth -= damageAmount * damageAmount / (damageAmount + defenseLevel);

        if (currentPlayerHealth <= 0f)
        {
            Debug.Log("Player is dead. :-(");
        }
    }

    public void CastFromMana(float manaUseAmount)
    {
        currentPlayerMana -= manaUseAmount;

        if (currentPlayerMana <= 0f)
        {
            Debug.Log("Player has no mana.");
        }
    }

}
