using UnityEngine;

public class vgenerateurd : MonoBehaviour
{
    public int venergie = 0; // Déclarez la variable venergie à l'intérieur de la classe

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Récupérer le script Player attaché à l'objet du joueur
            player player = collision.GetComponent<player>();

            // Vérifier si le script Player existe sur l'objet du joueur
            if (player != null)
            {
                // Augmenter la valeur de venergie en appelant une méthode du script Player
                player.IncreaseEnergy();

                // Obtenir une référence à l'objet InventoryUI dans la scène
                InventoryUIs inventoryUIs = FindObjectOfType<InventoryUIs>();

                // Vérifier si l'objet InventoryUI a été trouvé
                if (inventoryUIs != null)
                {
                    // Appeler la méthode IncreaseEnergy() de l'objet InventoryUI
                }
                else
                {
                    Debug.LogWarning("Objet InventoryUI introuvable dans la scène.");
                }
            }
            else
            {
                // Afficher un message d'erreur si le script Player n'est pas trouvé
                Debug.LogWarning("Le script Player n'a pas été trouvé sur l'objet du joueur.");
            }
        }
    }
}
