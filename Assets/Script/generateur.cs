using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateur : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Récupérer la référence à la composante barvi attachée à cet objet
            barvi barvi = transform.GetComponent<barvi>();

            // Augmenter la variable health de 1
            barvi.health += 2;
        }
    }
}