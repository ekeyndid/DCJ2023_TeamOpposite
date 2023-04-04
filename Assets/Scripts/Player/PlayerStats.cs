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

    // This script is specifically designed to hold all player stats, like health, mana, defense and so on
    // Methods should be made so that other game objects (like enemies) can modify the variables without accessing them directly

    [SerializeField] private float currentPlayerHealth;
    //[SerializeField] private float currentPlayerDefense;
    [SerializeField] private float currentPlayerMana;

    [SerializeField] private float maxPlayerHealth;
    //[SerializeField] private float maxPlayerDefense;
    [SerializeField] private float maxPlayerMana;

    [SerializeField] private float attackLevel;
    [SerializeField] private float defenseLevel;
    
    public void HealPlayer(float healAmount)
    {
        currentPlayerHealth += healAmount;

        if (currentPlayerHealth > maxPlayerHealth) currentPlayerHealth = maxPlayerHealth;
    }

    public void DamagePlayer(float damageTaken)
    {
        currentPlayerHealth -= damageTaken;
        
        if (currentPlayerHealth <= 0f) Debug.Log("Player is dead :-(");
    }

    public void RestoreMana(float manaToRestore)
    {
        currentPlayerMana += manaToRestore;

        if (currentPlayerMana > maxPlayerMana) currentPlayerMana = maxPlayerMana;
    }

    public void CastFromMana(float manaToUse)
    {
        currentPlayerMana -= manaToUse;
    }
}
