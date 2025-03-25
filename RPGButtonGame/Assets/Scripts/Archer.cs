using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static UnityEngine.GraphicsBuffer;

public class Archer : Enemy
{
    [SerializeField] private int arrowDamage = 2;
    public override int Attack()
    {
        int arrowsShot = Random.Range(1, 4); 
        int totalDamage = 0;

        for (int i = 0; i < arrowsShot; i++)
        {
            totalDamage += arrowDamage;
            Debug.Log($"Archer shoots arrow {i + 1}");
        }

        return totalDamage;
    }
}
