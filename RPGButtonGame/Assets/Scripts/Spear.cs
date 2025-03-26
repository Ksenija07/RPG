using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public override void ApplyEffect(Character character)
    {
        
    }

    public void SelectWeapon(Character character)
    {
        character.EquipWeapon(this);
        Debug.Log("Spear selected!");

        if (gameManager != null)
        {
            gameManager.UpdateSelectedWeaponText("Spear!");
        }
    }
}
