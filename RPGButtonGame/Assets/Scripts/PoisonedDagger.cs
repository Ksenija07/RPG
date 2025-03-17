using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonedDagger : Weapon
{
    [SerializeField] private int poisonDamage = 2;
    [SerializeField] private int poisonTurns = 2;
    public override void ApplyEffect(Character character)
    {
        int totalDamage = 0;
        totalDamage += Random.Range(minDamage, maxDamage + 1) + poisonDamage;
      
    }

}
