using UnityEngine;
using System.Collections;

public class EnnemiSuiveur : MonoBehaviour
{
    public float vitesseDeplacement = 3f; 
    public float distanceDetection = 5f; 
    public LayerMask masqueCollision; 
    public float degats = 10f; // Dégâts infligés au joueur
    public float blocageDuration = 2f; // Durée de blocage après avoir été touché par un objet électrique

    private Transform joueur; 
    private bool peutInfligerDegats = true; 
    private bool estBloque = false; // Indique si l'ennemi est bloqué par un objet électrique

    private void Start()
    {
        joueur = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (!estBloque && Vector2.Distance(transform.position, joueur.position) < distanceDetection)
        {
            transform.position = Vector2.MoveTowards(transform.position, joueur.position, vitesseDeplacement * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && peutInfligerDegats)
        {
            // Infliger des dégâts au joueur
            barvi barvi = other.GetComponent<barvi>();
            barvi.TakeDamage(10);
            peutInfligerDegats = false; // Empêche les dégâts répétés pendant un certain temps
            StartCoroutine(ReenableDamage());
        }
        else if (other.CompareTag("electrique"))
        {
            estBloque = true; // L'ennemi est bloqué par un objet électrique
            StartCoroutine(UnblockAfterDuration());
        }
    }

    IEnumerator ReenableDamage()
    {
        yield return new WaitForSeconds(1f); // Temps pendant lequel l'ennemi ne peut pas infliger de dégâts
        peutInfligerDegats = true;
    }

    IEnumerator UnblockAfterDuration()
    {
        yield return new WaitForSeconds(blocageDuration); // Temps pendant lequel l'ennemi est bloqué
        estBloque = false;
    }
}
