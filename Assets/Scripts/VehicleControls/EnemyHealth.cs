/*
 * AUTHOR: SHAWN GRANT
 * PURPOSE: INCREASE, DECREASE AND UPDATE HEALTH
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public Slider healthBar;
    public GameObject deathFx;
    public GameObject healthDrop;
    int health;
    AudioSource audioFX;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        //healthBar.maxValue = maxHealth;
        audioFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //healthBar.value = health;

        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int amt)
    {
        health -= amt;
    }

    public void Heal(int amt)
    {
        health += amt;
    }

    public void Die()
    {
        
        //Instantiate(healthDrop, transform.position + new Vector3(0, 2, 0), new Quaternion());
        Destroy(gameObject, 5);
    }
}
