using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject salle1Object; // Référence à l'objet représentant la salle 1
    public AfficherMap mapScript; // Référence au script AfficherMap pour modifier la variable salle1Active

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si le joueur entre en collision avec l'objet de la salle 1
        if (other.gameObject == salle1Object)
        {
            // Détruit le joueur
            Destroy(gameObject);

            // Définir salle1Active à vrai dans le script AfficherMap
            if (mapScript != null)
            {
                mapScript.salle1Active = true;
            }
            else
            {
                Debug.LogWarning("Le script AfficherMap n'est pas attaché ou référencé.");
            }
        }
    }
}
