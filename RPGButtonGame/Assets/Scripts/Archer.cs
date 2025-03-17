using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Archer : Enemy
{
    [SerializeField] internal int aggresioGain = 5;
    public override int Attack()
    {
        aggresion += aggresioGain;
        return aggresion / 10;
    }
}
