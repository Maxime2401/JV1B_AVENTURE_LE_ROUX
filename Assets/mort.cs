using UnityEngine;

public class ElectrocuterEtLooter : MonoBehaviour
{
    public GameObject objetALooter; // Objet à faire apparaître lorsque cet objet entre en collision avec un objet électrique

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("electrique"))
        {
            // Si l'objet électrique est touché, détruire cet objet
            Destroy(gameObject);

            // Si un objet est défini pour être looté, le faire apparaître à la position de cet objet
            if (objetALooter != null)
            {
                Instantiate(objetALooter, transform.position, Quaternion.identity);
            }
        }
    }
}
