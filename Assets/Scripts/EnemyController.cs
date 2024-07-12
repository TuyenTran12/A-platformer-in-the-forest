using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float bounce;
    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            Destroy(gameObject);
            rb.velocity = new Vector2(rb.velocity.x, bounce);
        }

    }
}
