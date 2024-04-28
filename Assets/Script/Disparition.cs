using UnityEngine;

public class dev : MonoBehaviour
{
    public GameObject violet; // Déclare le GameObject Violet

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("electrique"))
        {
            player player = other.GetComponent<player>(); // Change le nom de la variable en camelCase

            // Détruit le GameObject Violet
            Destroy(violet);
        }
    }
}
