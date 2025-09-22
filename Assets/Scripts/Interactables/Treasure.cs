using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Treasure : MonoBehaviour, IInteractable
{
    [SerializeField] private bool IsOpen;
    [SerializeField] private Sprite openedSprite;
    [SerializeField] private GameObject itemPrefab;

    public bool CanInteract()
    {
        return !IsOpen;
    }

    public void Interact()
    {
        if (IsOpen)
        {
            return;
        }

        IsOpen = true;
        GetComponent<SpriteRenderer>().sprite = openedSprite;
        GetComponent<Animator>().SetBool("IsOpen", true);

        Instantiate(itemPrefab, transform.position + Vector3.down + Vector3.left, Quaternion.identity);
    }
}
