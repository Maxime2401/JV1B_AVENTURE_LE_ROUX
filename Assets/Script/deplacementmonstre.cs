using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    public Transform pointA; // Point de départ
    public Transform pointB; // Point d'arrivée
    public float speed = 1f; // Vitesse de déplacement du monstre
    public float blockTime = 2f; // Temps de blocage après avoir été touché par un objet électrique

    private bool movingTowardsB = true; // Indique si le monstre se déplace vers B
    private bool canMove = true; // Indique si le monstre peut bouger

    void Update()
    {
        if (canMove)
        {
            if (movingTowardsB)
            {
                // Déplacer le monstre vers le point B
                transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);

                // Vérifier si le monstre atteint le point B
                if (transform.position == pointB.position)
                {
                    movingTowardsB = false; // Mettre à jour la direction de déplacement
                }
            }
            else
            {
                // Déplacer le monstre vers le point A
                transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);

                // Vérifier si le monstre atteint le point A
                if (transform.position == pointA.position)
                {
                    movingTowardsB = true; // Mettre à jour la direction de déplacement
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("electrique"))
        {
            canMove = false; // Désactiver le mouvement de l'ennemi
            StartCoroutine(UnblockAfterTime()); // Démarrer la coroutine pour débloquer le mouvement après un certain temps
        }
    }

    IEnumerator UnblockAfterTime()
    {
        yield return new WaitForSeconds(blockTime); // Attendre pendant le temps spécifié
        canMove = true; // Réactiver le mouvement de l'ennemi
    }
}
