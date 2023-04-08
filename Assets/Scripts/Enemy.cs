using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string name;
    public float attackLevel;
    public float defenseLevel;
    public float health;

    float Attack()
    {
        return attackLevel;
    }
}
