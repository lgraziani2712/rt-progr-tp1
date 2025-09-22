using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Lever : MonoBehaviour, IInteractable
{
    [SerializeField] private bool IsPulled;
    [SerializeField] private Sprite pulledSprite;
    [SerializeField] private GameObject doorToOpen;
    [SerializeField] private GameObject ceilingToClear;

    public bool CanInteract()
    {
        return !IsPulled;
    }

    public void Interact(Transform player)
    {
        if (IsPulled)
        {
            return;
        }

        IsPulled = true;
        GetComponent<SpriteRenderer>().sprite = pulledSprite;
        doorToOpen.GetComponent<IInteractable>().Interact(player);
        ceilingToClear.GetComponent<IInteractable>().Interact(player);
    }
}
