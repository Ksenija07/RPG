using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonedDagger : Weapon
{
    [SerializeField] private int poisonDamage = 2;
    private GameManager gameManager;

    // Property for Poison Damage
    private int PoisonDamage
    {
        get => poisonDamage;
        set
        {
            poisonDamage = Mathf.Max(0, value); // Ensures poison damage is not negative
        }
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public override void ApplyEffect(Character character)
    {
        int totalDamage = Random.Range(minDamage, maxDamage + 1) + PoisonDamage;
        Debug.Log($"Added poison damage: {totalDamage}");
        character.GetHit(totalDamage);
    }

    public void SelectWeapon(Character character)
    {
        character.EquipWeapon(this);
        Debug.Log("Poisoned Dagger selected!");

        if (gameManager != null)
        {
            gameManager.UpdateSelectedWeaponText("Poisoned Dagger");
        }
    }
}
