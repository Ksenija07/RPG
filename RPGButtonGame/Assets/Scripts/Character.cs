using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public float maxHealth;
    public GameManager gameManager;
    [SerializeField] private bool isDead;
    [SerializeField] private Weapon activWeapon;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        if(health <=0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
            Debug.Log("Dead");
        }
    }
    public Weapon Activeweapon
    {
       get { return activWeapon; }
    }

    public virtual int Attack()
    {
        Debug.Log(name + " attacking");
        return activWeapon.GetDamage();
    }
   
    public void GetHit(int damage)
    {
        health -= damage;
        health = Mathf.Max(health, 0);
        Debug.Log(name + " current health " + health);
    }

    public void GetHit(Weapon weapon)
    {
        health -= weapon.GetDamage();
        Debug.Log(name + " Got hit by " + weapon.name);
        Debug.Log(name + " current health " + health);
    }
}


