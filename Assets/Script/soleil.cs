using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sol : MonoBehaviour
{       
    public void EnableRege()
    {
        canrege = true;
        Debug.Log("marche");
    }
    private bool canrege = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sol") && canrege)
        {
            Debug.Log("marche  12");
            // Récupérer la référence à la composante barvi attachée à cet objet
            barvi barvi = transform.GetComponent<barvi>();

            // Augmenter la variable health de 1
            barvi.TakeEnergie(1); // Utilisation de la méthode TakeEnergie
            Debug.Log("marche4");
        }
    }
    
}
