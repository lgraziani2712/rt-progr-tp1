using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    private void OnMove(InputValue input)
    {
        Vector2 move = input.Get<Vector2>();

        GetComponent<Animator>().SetBool("IsRunning", move.x != 0 || move.y != 0);
    }
}
