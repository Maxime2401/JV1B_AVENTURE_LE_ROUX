using UnityEngine;
using UnityEngine.UI;
public class ShopItem : MonoBehaviour
{   

    public GameObject selectedItemIcon; // Référence à l'icône d'objet sélectionné (coche, icône, etc.)

    private bool isSelected = false; // Indique si l'objet est sélectionné ou non

    // Méthode appelée lorsque le joueur interagit avec l'objet du shop
    public void OnItemClick()
    {
        // Vérifier si le joueur a assez de pièces pour acheter l'item
        
        

         isSelected = !isSelected;
        selectedItemIcon.SetActive(isSelected);
        
    }
}
