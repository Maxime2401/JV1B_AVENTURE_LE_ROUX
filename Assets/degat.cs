using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject item; // Référence à l'objet à faire apparaître lorsque l'ennemi est détruit par un objet électrique
    private bool canDealDamage = true; // Indique si le script peut infliger des dégâts au joueur
    public float disableTime = 3f; // Temps de désactivation du script après avoir été touché par un trigger électrique

    // Fonction OnTriggerEnter2D pour détecter les collisions avec le joueur et les triggers électriques
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifie si l'ennemi est touché par un objet électrique
        if (collision.CompareTag("electrique"))
        {
            // Fait apparaître l'objet et détruit l'ennemi
            if (item != null)
            {
                Instantiate(item, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
