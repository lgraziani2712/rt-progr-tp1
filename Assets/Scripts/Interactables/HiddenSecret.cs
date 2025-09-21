using UnityEngine;

public class HiddenSecret : MonoBehaviour, IInteractable
{
    public bool CanInteract()
    {
        return false;
    }

    public void Interact()
    {
        Destroy(gameObject);
    }
}
