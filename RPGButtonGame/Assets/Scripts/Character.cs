using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public float maxHealth;
    public GameManager gameManager;
    [SerializeField] public bool isDead;
    [SerializeField] private Weapon activWeapon;
    private Shield shield;

    void Start()
    {
        maxHealth = health;
        shield = GetComponent<Shield>();
    }

   
    public Weapon Activeweapon
    {
       get { return activWeapon; }
    }

    public void EquipWeapon(Weapon newWeapon)
    {
        activWeapon = newWeapon;
        Debug.Log(name + " equipped " + activWeapon.name);
    }

    public virtual int Attack()
    {
        Debug.Log(name + " attacking");
        return activWeapon.GetDamage();
    }
   
    public void GetHit(int damage)
    {
        if(shield != null)
        {
            damage = shield.AbsorbDamage(damage);
        }
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


