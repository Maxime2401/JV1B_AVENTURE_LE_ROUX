using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget; // La position de téléportation où le joueur doit être téléporté
    private bool moov = false; // Variable pour vérifier si le joueur est en mouvement

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) // Vérifie si la touche "T" est enfoncée
        {
            Teleport(); // Appelle la fonction de téléportation
        }
    }

    void Teleport()
    {
        if (!moov && teleportTarget != null) // Vérifie si le joueur n'est pas en train de se déplacer et si le point de téléportation est défini
        {
            StopAllCoroutines(); // Arrête tous les mouvements en cours
            transform.position = teleportTarget.position; // Téléporte le joueur à la position du point de téléportation
        }
        else
        {
            Debug.LogWarning("Impossible de téléporter. Le joueur est en mouvement ou le point de téléportation n'est pas défini.");
        }
    }

    // Ajoutez ici une fonction pour mettre à jour la variable moov en fonction de l'état de déplacement du joueur
    public void SetMovingState(bool moving)
    {
        moov = moving;
    }
}
