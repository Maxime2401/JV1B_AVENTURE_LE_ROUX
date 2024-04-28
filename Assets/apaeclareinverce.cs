using UnityEngine;
using System.Collections;

public class DisparitionReapparitioninverce : MonoBehaviour
{
    public float tempsDisparition = 2f; // Temps pendant lequel l'objet reste invisible
    public float tempsReapparition = 3f; 
    
    public float tempsDisparitionbugereffet = 0.02f;


    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(DisparaitreEtReapparaitre());
    }

    IEnumerator DisparaitreEtReapparaitre()
    {
        while (true)
        {
            // Disparition de l'objet
            rend.enabled = false;
            yield return new WaitForSeconds(tempsDisparition);

            // Réapparition de l'objet
            rend.enabled = true;
            yield return new WaitForSeconds(tempsReapparition);

            rend.enabled = false;
            yield return new WaitForSeconds(tempsDisparitionbugereffet);


        }
    }
}
