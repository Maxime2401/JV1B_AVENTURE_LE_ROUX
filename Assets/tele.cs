using UnityEngine;

public class teleTrigger : MonoBehaviour
{
    public GameObject shopUI; // Référence à l'interface utilisateur du shop

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Activer l'interface utilisateur du shop
            if (shopUI != null)
            {
                shopUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Désactiver l'interface utilisateur du shop lorsque le joueur quitte le shop
            if (shopUI != null)
            {
                shopUI.SetActive(false);
            }
        }
    }
}
