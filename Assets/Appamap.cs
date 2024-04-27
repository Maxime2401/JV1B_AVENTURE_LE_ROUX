using UnityEngine;

public class AfficherMap : MonoBehaviour
{
    public GameObject mapUI; // Référence à votre panneau/UI de map
    public GameObject salle1Image; // Référence à l'image de la salle 1

    public bool salle1Active = false; // Définir à vrai lorsque la salle 1 est active

    void Update()
    {
        // Vérifie si la touche M est enfoncée
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Active ou désactive le panneau/UI de map selon son état actuel
            mapUI.SetActive(!mapUI.activeSelf);

            // Si la salle 1 est active, active son image
            if (salle1Active)
            {
                salle1Image.SetActive(true);
            }
        }
    }
}
