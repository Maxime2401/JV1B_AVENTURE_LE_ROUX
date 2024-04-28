using UnityEngine;

public class MonsterMovementABCD : MonoBehaviour
{
    public Transform pointA; // Point A
    public Transform pointB; // Point B
    public Transform pointC; // Point C
    public Transform pointD; // Point D
    public float speed = 1f; // Vitesse de déplacement du monstre

    private Transform currentTarget; // Cible actuelle du monstre

    void Start()
    {
        // Initialiser la cible actuelle comme étant le point B
        currentTarget = pointA;
    }

    void Update()
    {
        // Déplacer le monstre vers la cible actuelle
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

        // Vérifier si le monstre atteint la cible actuelle
        if (transform.position == currentTarget.position)
        {
            // Changer la cible en fonction de la direction de déplacement
            if (currentTarget == pointA)
                currentTarget = pointB;
            else if (currentTarget == pointB)
                currentTarget = pointC;
            else if (currentTarget == pointC)
                currentTarget = pointD;
            else if (currentTarget == pointD)
                currentTarget = pointA;
        }
    }
}
