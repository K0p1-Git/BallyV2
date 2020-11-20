using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public int health = 100;
    public EnemyDeath enemyDeath;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        FindObjectOfType<AudioManager>().Play("painSFX");

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        FindObjectOfType<AudioManager>().Play("deathSFX");
        Instantiate(enemyDeath, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
