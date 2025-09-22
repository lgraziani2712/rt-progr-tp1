using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    [SerializeField] int health = 3;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            health--;
            animator.SetTrigger("BeingAttacked");

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
