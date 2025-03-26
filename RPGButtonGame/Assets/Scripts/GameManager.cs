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
    [SerializeField] private TMP_Text damageLogText;
    [SerializeField] private Enemy[] enemyTypes;
    [SerializeField] private TMP_Text selectedWeaponText;


    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = player.CharName;
        enemyNameText.text = enemy.name;
        UpdateUI();
    }

    public void DoRound()
    {
        int playerDamage = player.Attack();
        enemy.GetHit(playerDamage);
        player.Activeweapon.ApplyEffect(enemy);
        damageLogText.text = $"Player dealt {playerDamage} damage!";

        if (enemy.health <= 0)
        {
            Debug.Log($"{enemy.name} is defeated!");
            damageLogText.text += $"\n{enemy.name} was defeated!";
            SpawnNewEnemy();
        }
        else
        {
            int enemyDamage = enemy.Attack();
            player.GetHit(enemyDamage);
            enemy.Activeweapon.ApplyEffect(player);
            damageLogText.text += $"\nEnemy dealt {enemyDamage} damage!";
        }

        UpdateUI();

        if (player.health <= 0)
        {
            gameOver();
        }
    }

    private void SpawnNewEnemy()
    {
        int randomIndex = Random.Range(0, enemyTypes.Length);
        enemy = enemyTypes[randomIndex];
        enemy.health = Mathf.RoundToInt(enemy.maxHealth);
        enemyNameText.text = enemy.name;
        Debug.Log($"A new enemy appears: {enemy.name}!");
    }

    private void UpdateUI()
    {
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

    public void UpdateSelectedWeaponText(string weaponName)
    {
        selectedWeaponText.text = "Selected Weapon: " + weaponName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
