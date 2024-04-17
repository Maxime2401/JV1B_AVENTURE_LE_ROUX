using UnityEngine;
using System.Collections;

public class TapisRoulant : MonoBehaviour
{
    public Vector2 pushDirection = Vector2.right; // Direction dans laquelle pousser le joueur
    public float Vitesse = 0.2f; // Vitesse de déplacement du joueur sur le tapis
    public float delay = 1f; // Délai avant que le joueur ne commence à être déplacé

    private bool moov = false; // Indique si le joueur est en train de se déplacer

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !moov)
        {
            StartCoroutine(MovePlayerOnConveyor(other.transform));
        }
    }

    IEnumerator MovePlayerOnConveyor(Transform playerTransform)
    {
        moov = true; // Le joueur commence à se déplacer

        yield return new WaitForSeconds(delay); // Attendre pendant le délai spécifié

        Vector3 startPos = playerTransform.position;
        Vector3 endPos = startPos + (Vector3)pushDirection;

        float journeyLength = Vector3.Distance(startPos, endPos); // Longueur du déplacement

        float startTime = Time.time; // Heure de début du déplacement

        while (Time.time < startTime + Vitesse)
        {
            float distCovered = (Time.time - startTime) * Vitesse;
            float fracJourney = distCovered / journeyLength;
            playerTransform.position = Vector3.Lerp(startPos, endPos, fracJourney);
            yield return null;
        }

        playerTransform.position = endPos; // Assurez-vous que le joueur arrive à la destination exacte

        moov = false; // Réinitialiser la variable moov à false pour permettre au joueur de bouger librement
    }
}
