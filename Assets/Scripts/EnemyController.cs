using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyParent;
    public Rigidbody2D rb;
    public float bounce = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            Destroy(enemyParent);
            rb.AddForce(Vector2.up * bounce);
        }
    }
     
}
