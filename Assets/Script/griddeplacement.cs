using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class griddeplacement : MonoBehaviour
{
    private Vector3 startPos, endPos;
    private bool moov = false;
    private bool canmove = true;
    private bool murGauche = false;
    private bool murDroit = false;
    private bool murHaut = false;
    private bool murBas = false;
    public float Vitesse = 0.2f;
    public Collider2D captgauche;
    public Collider2D captdroit;
    public Collider2D capthaut;
    public Collider2D captbas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wallgauche"))
        {
            murGauche = true;
        }
        else if (other.CompareTag("Walldroit"))
        {
            murDroit = true;
        }
        else if (other.CompareTag("Wallhaut"))
        {
            murHaut = true;
        }
        else if (other.CompareTag("Wallbas"))
        {
            murBas = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wallgauche"))
        {
            murGauche = false;
        }
        else if (other.CompareTag("Walldroit"))
        {
            murDroit = false;
        }
        else if (other.CompareTag("Wallhaut"))
        {
            murHaut = false;
        }
        else if (other.CompareTag("Wallbas"))
        {
            murBas = false;
        }
        if (other.CompareTag("Genera"))
        {
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeEnergie(1);
        }
    }
    
    
    
        
    

    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.Z) && !murHaut)
        {
            y = 1f; // Haut
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeDamage(1);
            //barvi invincible = transform.GetComponent<barvi>();
            //invincible.invincible = false;
            
        }
        else if (Input.GetKey(KeyCode.S) && !murBas)
        {
            y = -1f; // Bas
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeDamage(1);//-1 énergie
        }

        if (Input.GetKey(KeyCode.Q) && !murGauche)
        {
            x = -1f; // Gauche
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeDamage(1);//-1 énergie
        }
        else if (Input.GetKey(KeyCode.D) && !murDroit)
        {
            x = 1f; // Droite
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeDamage(1);//-1 énergie
        }

        if (!moov && canmove)
        {
            StartCoroutine(MovePlayer(new Vector3(x, y, 0f)));
        }
    }

    IEnumerator MovePlayer(Vector3 dir)
    {
        moov = true;
        float nextMove = 0f;
        startPos = transform.position;
        endPos = startPos + dir;

        while (nextMove < Vitesse)
        {
            transform.position = Vector3.Lerp(startPos, endPos, nextMove / Vitesse);
            nextMove += Time.deltaTime;
            yield return null;
        }

        transform.position = endPos;
        moov = false;
    }
}
