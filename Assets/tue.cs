using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("Collision with " + other.tag + " detected!");

        // Si la collision est avec un joueur et ce script peut infliger des dégâts
        if (other.CompareTag("Player") )
        {
             barvi barvi = other.GetComponent<barvi>();

            // Si le composant barvi existe sur le joueur
            if (barvi != null)
            {
                // Infligez des dégâts au joueur
                barvi.TakeDamage(4);
                Debug.Log("Damage dealt to player!");

            }
        }
    }
}