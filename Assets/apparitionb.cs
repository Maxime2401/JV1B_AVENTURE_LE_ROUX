using UnityEngine;

public class InventoryUI : MonoBehaviour
{   
    public GameObject eneroff;
    public GameObject eneron;
    public GameObject tazz;
    public GameObject inventoryPanel; // Référence au panneau de l'inventaire dans l'UI
    public GameObject panneaux;
    private bool canrege = false;    
    private bool canAttack = false;


    public void EnableAttack()
    {
        canAttack = true;
    }


    public void EnableRege()
    {
        canrege = true;
        Debug.Log("marche22");
    }
    void Update()
    {
        if (canAttack)
        {
            eneroff.SetActive(true);
        }



        if (Input.GetKeyDown(KeyCode.I))
        {
            // Inverse l'état d'activation du panneau de l'inventaire
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
            if (canrege)
            {
                panneaux.SetActive(!panneaux.activeSelf);
            }
            if (canAttack)
            {
                tazz.SetActive(!tazz.activeSelf);
                
            }
        }
    }
}
