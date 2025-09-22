using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
