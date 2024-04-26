using UnityEngine;

public class gene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sol sol = other.GetComponent<sol>();
            if (sol != null)
            {
                // Le joueur prend cet objet
                sol.EnableRege();

                // Récupérer l'instance de l'objet InventoryUI dans la scène
                InventoryUIs inventoryUIs = FindObjectOfType<InventoryUIs>();

                // Vérifier si l'objet InventoryUI a été trouvé
                if (inventoryUIs != null)
                {
                    // Appeler la méthode EnableRege() de l'objet InventoryUI
                    inventoryUIs.EnableRege();
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
