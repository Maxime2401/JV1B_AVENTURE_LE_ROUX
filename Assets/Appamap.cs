using UnityEngine;

public class MapUIs : MonoBehaviour
{   
    public GameObject salle2;
    public GameObject carte; // Référence au panneau de l'inventaire dans l'UI
    public GameObject salle1;
    private bool salle1Active = false;    
    private bool salle2Active = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Touche M pressée !");

            // Inverse l'état d'activation du panneau de la carte
            carte.SetActive(!carte.activeSelf);

            // Si la salle 1 est active, active ou désactive la salle 1
            if (salle1Active)
            {
                salle1.SetActive(!salle1.activeSelf);
                Debug.Log("Activation/Désactivation de la salle 1 !");
            }

            // Si la salle 2 est active, active ou désactive la salle 2
            if (salle2Active)
            {
                salle2.SetActive(!salle2.activeSelf);
                Debug.Log("Activation/Désactivation de la salle 2 !");
            }
        }
    }

    // Méthode appelée lorsque la salle 1 doit être activée
    public void EnableSalle1()
    {
        salle1Active = true;
        Debug.Log("Salle 1 activée !");
    }

    // Méthode appelée lorsque la salle 2 doit être activée
    public void EnableSalle2()
    {
        salle2Active = true;
        Debug.Log("Salle 2 activée !");
    }
}
