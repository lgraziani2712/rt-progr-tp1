using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class ScreenController : MonoBehaviour
{
    [SerializeField] GameObject player;
    private PlayerInput playerInput;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        Time.timeScale = 0;

    }

    private void OnStart(InputValue input)
    {
        Time.timeScale = 1;

        player.GetComponent<PlayerInput>().actions.FindActionMap("Player", true).Enable();

        Destroy(gameObject);
    }
}
