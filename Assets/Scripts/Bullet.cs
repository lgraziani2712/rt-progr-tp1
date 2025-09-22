using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Collider" || collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
