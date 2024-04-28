using UnityEngine;
using System.Collections;

public class DisparitionReapparitionecl : MonoBehaviour
{
    public float tempsDisparition = 2f; // Temps pendant lequel l'objet reste invisible
    public float tempsReapparition = 3f; 
    public float tempsDisparitionBugEffet = 0.02f;

    private Renderer rend;
    private Collider2D col;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<Collider2D>();
        StartCoroutine(DisparaitreEtReapparaitre());
    }

    IEnumerator DisparaitreEtReapparaitre()
    {   
        while (true)
        {
            // Disparition de l'objet
            rend.enabled = false;
            col.enabled = false; // Désactiver le collider
            yield return new WaitForSeconds(tempsDisparition);

            // Réapparition de l'objet
            rend.enabled = true;
            col.enabled = true; // Réactiver le collider
            yield return new WaitForSeconds(tempsReapparition);

            yield return new WaitForSeconds(tempsDisparitionBugEffet);
        }
    }
}
