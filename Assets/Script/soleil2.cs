using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soleil2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player canrege = transform.GetComponent<player>();// Vérifier si la collision est avec le joueur et si canrege est true
        if (collision.CompareTag("Player") && canrege == true)
        {
            // Récupérer la référence à la composante barvi attachée à cet objet
            barvi barvi = transform.GetComponent<barvi>();

            // Vérifier si barvi n'est pas null
            if (barvi != null)
            {
                // Augmenter la variable health de 1
                barvi.health += 1;
            }
        }
    }
}
