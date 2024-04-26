using UnityEngine;

public class Collectible1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventaire.instance.AddCoins(1);
             Destroy(gameObject);
            
        }
    }
}