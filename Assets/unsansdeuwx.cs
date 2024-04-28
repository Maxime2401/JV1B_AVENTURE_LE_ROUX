using UnityEngine;

public class DestroyExtraPlayers : MonoBehaviour
{
    void Start()
    {
        // Trouver tous les GameObjects avec le tag "Player"
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        // S'il y a plus d'un joueur, en détruire un
        if (players.Length > 1)
        {
            // Détruire le deuxième joueur trouvé
            Destroy(players[1]);
        }
    }
}
