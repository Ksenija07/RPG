using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Player player;
    public Enemy enemy;
    public Character character;
    // Start is called before the first frame update
    void Start()
    {
        player.Attack();
        Debug.Log("player name:" + player.CharName);
        enemy.Attack();
        character.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
