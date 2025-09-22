using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float force = 5f;
    [SerializeField] private GameObject bulletPrefab;

    private void OnAttack(InputValue input)
    {
        GameObject bullet = Instantiate(
            bulletPrefab,
            transform.position,
            Quaternion.identity
        );
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(transform.up * force, ForceMode2D.Impulse);
    }
}
