using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonedDagger : Weapon
{
    [SerializeField] private int poisonDamage = 2;
    public override void ApplyEffect(Character character)
    {
        int totalDamage = 0;
        totalDamage += Random.Range(minDamage, maxDamage + 1) + poisonDamage;
        Debug.Log("Added poison damage: " + totalDamage);
        character.GetHit(totalDamage);
    }

    public void SelectWeapon(Character character)
    {
        character.EquipWeapon(this); 
        Debug.Log("Poisoned Dagger selected!");
    }

}
