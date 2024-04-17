using UnityEngine;

public class porte : MonoBehaviour
{
    public int venergie = 0; // Déclarer la variable venergie à l'intérieur de la classe

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && venergie > 0) // Vérifie si venergie est strictement supérieure à 1
        {
            player player = other.GetComponent<player>();
            if (player != null)
            {
                Debug.LogWarning("Le joueur a plus d'une unité de venergie.");
            }

            // Détruire cet objet
            Destroy(gameObject);
        }
    }
}
