using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    [SerializeField] private int additionalDamage = 5;
    public override void ApplyEffect(Character character)
    {
        int arrowsShot = Random.Range(1, 3); 
        int totalDamage = 0;

        for (int i = 0; i < arrowsShot; i++)
        {
            totalDamage += Random.Range(minDamage, maxDamage + 1) + additionalDamage;
        }
        character.GetHit(totalDamage);
    }

    public void SelectWeapon(Character character)
    {
        character.EquipWeapon(this);
        Debug.Log("Bow selected!");
    }
}
