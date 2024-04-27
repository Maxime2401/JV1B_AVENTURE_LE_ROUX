using UnityEngine;

public class SuivreJoueur : MonoBehaviour
{
    public Transform joueur; // Référence au transform du joueur
    public float vitesseSuivi = 5f; // Vitesse de déplacement pour suivre le joueur

    void Update()
    {
        // Vérifier si le joueur existe
        if (joueur != null)
        {
            // Calculer la nouvelle position vers laquelle se déplacer en utilisant Lerp
            Vector3 nouvellePosition = Vector3.Lerp(transform.position, joueur.position, vitesseSuivi * Time.deltaTime);

            // Déplacer ce GameObject vers la nouvelle position
            transform.position = nouvellePosition;
        }
    }
}
