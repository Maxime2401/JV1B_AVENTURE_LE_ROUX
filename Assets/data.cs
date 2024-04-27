using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance; // Pour créer un singleton

    public int moneyAmount = 0; // L'argent du joueur
    // Autres variables pour les objets, par exemple :
    // public int numberOfKeys = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Pour que ce GameObject persiste entre les scènes
        }
        else
        {
            Destroy(gameObject); // Détruire les doublons
        }
    }
}
