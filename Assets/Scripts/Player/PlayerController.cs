using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
  [SerializeField] private float moveSpeed = 5f;

  [Header("Dashing")]
  [SerializeField] private float dashSpeed = 4f;
  [SerializeField] private float dashDuration = 0.1f;
  [SerializeField] private float dashCooldown = 0.1f;
  private bool canDash = true;

  private Rigidbody2D rigidBody;

  private void Awake()
  {
    rigidBody = GetComponent<Rigidbody2D>();

    GetComponent<PlayerInput>().actions.FindActionMap("Player", true).Disable();
  }


  private void OnMove(InputValue input)
  {
    rigidBody.linearVelocity = input.Get<Vector2>() * moveSpeed;
  }

  private void OnDash(InputValue input)
  {
    if (canDash && (rigidBody.linearVelocity.x != 0 || rigidBody.linearVelocity.y != 0))
    {
      StartCoroutine(DashCoroutine());
    }

  }

  private IEnumerator DashCoroutine()
  {
    canDash = false;
    Vector2 baseVelocity = rigidBody.linearVelocity;

    rigidBody.linearVelocity *= dashSpeed;

    yield return new WaitForSeconds(dashDuration);

    rigidBody.linearVelocity = baseVelocity;

    yield return new WaitForSeconds(dashCooldown);

    canDash = true;
  }
}
