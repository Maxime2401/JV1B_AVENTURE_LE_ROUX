using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateur : MonoBehaviour
{
    private barvi playerBarvi; // Référence à la composante barvi attachée au joueur
    private bool isPlayerInside = false; // Indique si le joueur est à l'intérieur du générateur
    public float lifeIncreaseInterval = 1f; // Intervalle de temps entre chaque augmentation de vie

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Récupérer la référence à la composante barvi attachée à l'objet du joueur
            playerBarvi = collision.GetComponent<barvi>();

            // Vérifier si le composant barvi existe sur l'objet du joueur
            if (playerBarvi != null)
            {
                isPlayerInside = true; // Le joueur est maintenant à l'intérieur du générateur
                StartCoroutine(IncreaseLifeCoroutine()); // Démarrer la coroutine pour augmenter la vie du joueur
            }
            else
            {
                // Afficher un message d'erreur si le composant barvi n'est pas trouvé sur l'objet du joueur
                Debug.LogWarning("Le composant barvi n'a pas été trouvé sur l'objet du joueur.");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInside = false; // Le joueur n'est plus à l'intérieur du générateur
            StopCoroutine(IncreaseLifeCoroutine()); // Arrêter la coroutine qui augmente la vie du joueur
        }
    }

    private IEnumerator IncreaseLifeCoroutine()
    {
        while (isPlayerInside)
        {
            yield return new WaitForSeconds(lifeIncreaseInterval); // Attendre l'intervalle spécifié

            if (playerBarvi != null)
            {
                // Augmenter la variable health du joueur de 1
                playerBarvi.health += 1;
            }
            else
            {
                // Si le joueur a été détruit ou que la composante barvi a été supprimée
                Debug.LogWarning("Le joueur ou le composant barvi n'est plus disponible.");
                yield break; // Arrêter la coroutine
            }
        }
    }
}
