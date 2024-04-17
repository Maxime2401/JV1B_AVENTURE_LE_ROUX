using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private bool canDealDamage = true; // Indique si le script peut infliger des dégâts au joueur
    public float disableTime = 3f; // Temps de désactivation du script après avoir été touché par un trigger électrique

    // Fonction OnTriggerEnter2D pour détecter les collisions avec le joueur et les triggers électriques
    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("Collision with " + other.tag + " detected!");

        // Si la collision est avec un joueur et ce script peut infliger des dégâts
        if (other.CompareTag("Player") && canDealDamage)
        {
             barvi barvi = other.GetComponent<barvi>();

            // Si le composant barvi existe sur le joueur
            if (barvi != null)
            {
                // Infligez des dégâts au joueur
                barvi.TakeDamage(10);
                Debug.Log("Damage dealt to player!");

                // Désactiver la capacité de ce script à infliger des dégâts temporairement
                StartCoroutine(DisableDamageForTime());
            }
        }

        // Si la collision est avec un trigger portant le tag "electrique"
        if (other.CompareTag("electrique"))
        {
            // Désactiver la capacité de ce script à infliger des dégâts temporairement
            StartCoroutine(DisableDamageForTime());
        }
    }

    // Coroutine pour désactiver temporairement la capacité du script à infliger des dégâts
    IEnumerator DisableDamageForTime()
    {
        canDealDamage = false;
        yield return new WaitForSeconds(disableTime); // Attendre pendant le temps spécifié
        canDealDamage = true; // Réactiver la capacité du script à infliger des dégâts
    }
}
