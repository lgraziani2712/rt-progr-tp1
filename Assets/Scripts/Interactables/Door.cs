using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Animator))]
public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private bool IsOpen;

    [SerializeField] private Sprite openedSprite;

    public bool CanInteract()
    {
        return false;
    }

    public void Interact()
    {
        if (IsOpen)
        {
            return;
        }

        IsOpen = true;
        GetComponent<SpriteRenderer>().sprite = openedSprite;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Animator>().SetBool("IsOpen", true);
    }
}
