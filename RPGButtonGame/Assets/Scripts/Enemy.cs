using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] internal int aggresion = 10;

    private void Die()
    {
        Debug.Log("Enemy has died!");
       
    }
}
