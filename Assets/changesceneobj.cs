using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    // Nom de la scène vers laquelle on veut changer
    public string sceneName;

    // Si le joueur entre en collision avec cet objet
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si l'objet avec lequel on entre en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Changer de scène
            SceneManager.LoadScene(sceneName);
        }
    }
}
