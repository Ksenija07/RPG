using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    public override void ApplyEffect(Character character)
    {
        
    }

    public void SelectWeapon(Character character)
    {
        character.EquipWeapon(this);
        Debug.Log("Spear selected!");
    }
}
