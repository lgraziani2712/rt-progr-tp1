using UnityEngine;

public interface IInteractable
{
    public void Interact(Transform player);
    public bool CanInteract();
}
