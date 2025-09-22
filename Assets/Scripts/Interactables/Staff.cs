using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Staff : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject weaponPrefab;

    public bool CanInteract()
    {
        return true;
    }

    public void Interact(Transform player)
    {
        Instantiate(weaponPrefab, player.Find("Sprite"));

        Destroy(gameObject);
    }
}
