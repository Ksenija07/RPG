using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shield : MonoBehaviour
{
    [SerializeField] private int shieldMaxDurability = 10;
    private int shieldDurability;
    private bool isShieldActive = false;
    [SerializeField] private float shieldAbsorptionRate = 0.5f;
    public Button shieldButton;
    public TMP_Text shieldStatusText;

    void Start()
    {
        shieldDurability = shieldMaxDurability;
        isShieldActive = false;
        shieldButton.onClick.AddListener(ToggleShield);
        UpdateShieldUI();
    }

    public int AbsorbDamage (int damage)
    {
        if (isShieldActive && shieldDurability > 0)
        {
            int shieldAbsorbed = Mathf.RoundToInt(damage * shieldAbsorptionRate);
            int remainingDamage = damage - shieldAbsorbed;
            shieldDurability -= shieldAbsorbed;

            if(shieldDurability <= 0)
            {
                shieldDurability = 0;
                isShieldActive = false;
                Debug.Log("Shield is broken!");
                shieldStatusText.text = "Shield is Broken!";
            }
            else
            {
                shieldStatusText.text = $"Shield Durability: {shieldDurability}";
            }

            return remainingDamage;
        }

        return damage;
    }

    public void ToggleShield()
    {

        if (shieldDurability > 0)
        {
            isShieldActive = !isShieldActive;
            shieldStatusText.text = isShieldActive ? "Shield Activated!" : "Shield Deactivated!";
            Debug.Log(isShieldActive ? "Shield is Activated" : "Shield is Deactivated");
        }
        else
        {
            shieldStatusText.text = "Shield is Broken!";
            Debug.Log("Shield is broken");
        }
    }

    private void UpdateShieldUI()
    {
        shieldStatusText.text = $"Shield Durability: {shieldDurability}";
    }
}
