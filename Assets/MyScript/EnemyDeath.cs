using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }

}
