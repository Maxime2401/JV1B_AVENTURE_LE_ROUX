using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text coinText; // Référence à votre UI Text

    private int coinCount = 0; // Compteur de pièces

    // Méthode pour ajouter des pièces
    public void AddCoins(int amount)
    {
        coinCount += amount;
        UpdateCoinText();
    }

    // Méthode pour mettre à jour le texte des pièces
    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Pièces : " + coinCount.ToString();
        }
    }
}
