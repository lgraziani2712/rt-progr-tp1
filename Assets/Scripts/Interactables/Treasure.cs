using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
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

        Instantiate(itemPrefab, transform.position + Vector3.down + Vector3.left, Quaternion.identity);
    }
}
