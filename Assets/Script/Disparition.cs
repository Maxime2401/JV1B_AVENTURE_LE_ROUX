using UnityEngine;

public class dev : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("electrique"))
        {
            player player = other.GetComponent<player>();

            // détruire cet objet
            Destroy(gameObject);
        }
    }
}