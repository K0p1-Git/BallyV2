using UnityEngine;

public class Bullet : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 20f;
    public int damage = 15;
    public GameObject impactEffect;
    void Start()
    {
        rb.velocity = transform.right * speed;    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        FindObjectOfType<AudioManager>().Play("impactSFX");
        GameObject bullet = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(bullet, 1f);
    }
}
