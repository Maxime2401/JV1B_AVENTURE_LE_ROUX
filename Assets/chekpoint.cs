using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 checkpointPosition;

    private void Start()
    {
        // Au début, le checkpoint est défini sur sa propre position
        checkpointPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si le joueur touche le checkpoint
        if (other.CompareTag("Player"))
        {
            // Sauvegarder la position du checkpoint
            checkpointPosition = transform.position;
        }
    }

    // Méthode pour réinitialiser la position du joueur au checkpoint
    public void ResetPlayerPosition(GameObject player)
    {
        player.transform.position = checkpointPosition;
    }
}
