using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] internal int aggresioGain = 5;
    public override int Attack()
    {
        aggresion += aggresioGain;
        return aggresion / 10;
    }
}
