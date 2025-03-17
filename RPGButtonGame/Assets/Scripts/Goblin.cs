using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    [SerializeField] private int attackDamage = 5;
    [SerializeField] private float attackDelay = 0.5f;

    public override int Attack()
    {
        StartCoroutine(DoubleAttack());
        return (attackDamage * 2) / 10;
    }

    private IEnumerator DoubleAttack()
    {
        DealDamage(attackDamage);
        yield return new WaitForSeconds(attackDelay);
        DealDamage(attackDamage);
    }

    private void DealDamage(int damage)
    {
        Debug.Log($"Goblin attacks for {damage} damage!");
    }
}
