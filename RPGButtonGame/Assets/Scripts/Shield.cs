using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    [SerializeField] private int shieldMaxDurability = 10;
    private int shieldDurability;
    private bool isShieldActive = false;
    [SerializeField] private float shieldAbsorptionRate = 0.5f;
    public Button shieldButton;

    void Start()
    {
        shieldDurability = shieldMaxDurability;
        isShieldActive = false;
        shieldButton.onClick.AddListener(ToggleShield);
    }

    public int AbsorbDamage (int damage)
    {
        if (isActiveAndEnabled && shieldDurability > 0)
        {
            int shieldAbsorbed = Mathf.RoundToInt(damage * shieldAbsorptionRate);
            int remainingDamage = damage - shieldAbsorbed;
            shieldDurability -= shieldAbsorbed;

            if(shieldDurability <= 0)
            {
                shieldDurability = 0;
                isShieldActive = false;
                Debug.Log("Shield is broken!");
            }
            Debug.Log($"Shield Durability: {shieldDurability}");
            return remainingDamage;
        }

        return damage;
    }

    public void ToggleShield()
    {

        if (shieldDurability > 0)
        {
            isShieldActive = !isShieldActive;
            Debug.Log(isShieldActive ? "Shield is Activated" : "Shield is Deactivated");
        }
        else
        {
            Debug.Log("Shield is broken");
        }
    }
}
