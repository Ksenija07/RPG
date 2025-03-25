using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    [SerializeField] private int minDamage = 1;
    [SerializeField] private int maxDamage = 5;

    public override int Attack()
    {
        int damage1 = Random.Range(minDamage, maxDamage + 1); // First attack
        int damage2 = Random.Range(minDamage, maxDamage + 1); // Second attack
        int totalDamage = damage1 + damage2;

        Debug.Log($"Goblin attacks! First hit: {damage1} damage.");
        Debug.Log($"Goblin attacks again! Second hit: {damage2} damage.");

        return totalDamage;
    }
}
