using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Staff : MonoBehaviour, IInteractable
{
    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        Destroy(gameObject);
    }
}
