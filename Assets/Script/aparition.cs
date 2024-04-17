using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class apa : MonoBehaviour
{
    public float colliderToggleInterval = 1f; // Intervalle de temps entre chaque basculement de la Box Collider

    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>(); // Récupérer la référence à la Box Collider
        StartCoroutine(ToggleCollider()); // Démarrer la coroutine pour basculer la Box Collider
    }

    private IEnumerator ToggleCollider()
    {
        while (true)
        {
            yield return new WaitForSeconds(colliderToggleInterval); // Attendre l'intervalle spécifié
            
            // Inverser l'état de la Box Collider
            boxCollider.enabled = !boxCollider.enabled;
        }
    }
}
