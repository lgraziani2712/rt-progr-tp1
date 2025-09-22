using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
  [SerializeField] private float moveSpeed = 5f;
  private Rigidbody2D rigidBody;

  private void Awake()
  {
    rigidBody = GetComponent<Rigidbody2D>();
  }

  private void OnMove(InputValue input)
  {
    rigidBody.linearVelocity = input.Get<Vector2>() * moveSpeed;
  }
}
