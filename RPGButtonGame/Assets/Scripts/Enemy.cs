using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] internal int aggresion = 10;
    public GameObject berserker;
    public GameObject goblin;
    public GameObject archer;

    private void Die()
    {
        Debug.Log("Enemy has died!");
        //RespawnEnemy();
    }

    /*private void RespawnEnemy()
    {
        int randomEnemy = Random.Range(0, 3);

        GameObject enemyToRespawn = null;

        switch (randomEnemy)
        {
            case 0:
                enemyToRespawn = berserker;
                break;
            case 1:
                enemyToRespawn = goblin;
                break;
            case 2:
                enemyToRespawn = archer;
                break;
        }
    }*/
}
