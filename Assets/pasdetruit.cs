using UnityEngine;

public class DontDestroyBetweenScenes : MonoBehaviour
{
    void Awake()
    {
        // Ne pas détruire cet objet lors du chargement d'une nouvelle scène
        DontDestroyOnLoad(gameObject);
    }
}
