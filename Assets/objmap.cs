using UnityEngine;

public class mapobj : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MapUIs mapUIs = other.GetComponent<MapUIs>(); // Assurez-vous d'utiliser Player avec une majuscule
            if (mapUIs != null) // Correction de la casse de la variable mapUIs
            {
                // Activer l'attaque du joueur
                mapUIs.EnableSalle1(); // Utilisation de la variable mapUIs au lieu de MapUIs

                // Rechercher un objet InventoryUI dans la scène
            }
            else
            {
                Debug.LogWarning("Objet MapUIs introuvable sur le joueur.");
            }

            // Détruire cet objet
            Destroy(gameObject);
        }
    }
}
