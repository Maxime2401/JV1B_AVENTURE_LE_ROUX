using UnityEngine;

public class gener : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player player = other.GetComponent<player>(); // Assurez-vous d'utiliser Player avec une majuscule
            if (player != null)
            {
                // Activer l'attaque du joueur
                player.EnableAttack();

                // Rechercher un objet InventoryUI dans la scène
                InventoryUI inventoryUI = FindObjectOfType<InventoryUI>();

                // Vérifier si l'objet InventoryUI a été trouvé
                if (inventoryUI != null)
                {
                    // Appeler la méthode EnableAttack() de l'objet InventoryUI
                    inventoryUI.EnableAttack();
                }
                else
                {
                    Debug.LogWarning("Objet InventoryUI introuvable dans la scène.");
                }
            }

            // Détruire cet objet
            Destroy(gameObject);
        }
    }
}
