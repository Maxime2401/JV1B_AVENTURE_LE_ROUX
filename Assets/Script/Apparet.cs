using UnityEngine;

public class VotreScriptPrincipal : MonoBehaviour
{

    public GameObject inventaire; // Référence vers l'objet de votre inventaire

    void Update()
    {
        // Vérifie si la touche T est enfoncée
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Active ou désactive l'affichage de l'inventaire en fonction de son état actuel
            inventaire.SetActive(!inventaire.activeSelf);
        }
    }
}
