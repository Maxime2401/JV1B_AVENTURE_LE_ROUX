using UnityEngine;

public class SuiviAnimal : MonoBehaviour
{
    public Transform joueur; // Référence au joueur à suivre
    public float vitesseDeplacement = 5f; // Vitesse de déplacement de l'animal
    public float distanceMinimale = 2f; // Distance minimale entre l'animal et le joueur
    public float latence = 0.5f; // Temps de latence entre les mouvements de l'animal et du joueur

    private void Update()
    {
        // Vérifier si le joueur est défini
        if (joueur != null)
        {
            // Calculer la position cible de l'animal (avec latence)
            Vector3 positionCible = joueur.position - joueur.forward * latence;

            // Calculer la direction vers la position cible
            Vector3 direction = positionCible - transform.position;
            direction.Normalize(); // Normaliser la direction pour obtenir un vecteur de longueur 1

            // Calculer la distance entre l'animal et le joueur
            float distanceJoueur = Vector3.Distance(transform.position, joueur.position);

            // Si la distance est supérieure à la distance minimale, déplacer l'animal
            if (distanceJoueur > distanceMinimale)
            {
                // Déplacer l'animal dans la direction du joueur
                transform.Translate(direction * vitesseDeplacement * Time.deltaTime);
            }
        }
    }
}
