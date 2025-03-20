using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Player player;
    public Enemy enemy;
    
    public Character character;
    [SerializeField] private TMP_Text playerNameText, playerHealthText, enemyNameText, enemyHealthText;
    public GameObject GameOverUI;

        
    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = player.CharName;
        enemyNameText.text = enemy.name;
        playerHealthText.text = player.health.ToString();
        enemyHealthText.text = enemy.health.ToString();
    }

    public void DoRound()
    {
        int playerDamage = player.Attack();
        enemy.GetHit(playerDamage);
        player.Activeweapon.ApplyEffect(enemy);
        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);
        enemy.Activeweapon.ApplyEffect(player);
        playerHealthText.text = player.health.ToString();
        enemyHealthText.text = enemy.health.ToString();
    }

    public void gameOver()
    {
        GameOverUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
