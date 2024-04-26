using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject shopUIParent; // Référence au GameObject parent des éléments UI du shop

    // Méthode pour activer le shop et ses éléments UI
    public void ActivateShop()
    {
        shopUIParent.SetActive(true); // Activer les éléments UI du shop
    }

    // Méthode pour désactiver le shop et ses éléments UI
    public void DeactivateShop()
    {
        shopUIParent.SetActive(false); // Désactiver les éléments UI du shop
    }
}
