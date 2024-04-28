using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    public Transform pointA; // Point de départ
    public Transform pointB; // Point d'arrivée
    public float speed = 1f; // Vitesse de déplacement du monstre


    private bool movingTowardsB = true; // Indique si le monstre se déplace vers B
   

    void Update()
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
