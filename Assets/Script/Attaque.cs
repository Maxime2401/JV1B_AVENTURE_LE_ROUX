using UnityEngine;

public class player : MonoBehaviour
{   
    public GameObject ledobj;
    public GameObject attackObjectH; // Objet d'attaque haut
    public GameObject attackObjectG; // Objet d'attaque gauche
    public GameObject attackObjectB; // Objet d'attaque bas
    public GameObject attackObjectD; // Objet d'attaque droite
    public float attackDuration = 0.5f; // Durée de l'attaque
    private bool canAttack = false; // Indique si le joueur peut attaquer
    private int venergie = 0; // Variable pour stocker l'énergie
    public GameObject eneroff;
    public GameObject eneron;

    void Update()
    {
        if (canAttack && venergie >0 ) // Utilisez && pour vérifier deux conditions simultanément
        {   
            eneron.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && attackObjectH != null)
            {
                AttackH();
                eneron.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.Q)&& attackObjectG != null)
            {
                AttackG();
                eneron.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.S)&& attackObjectB != null)
            {
                AttackB();
                eneron.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.D)&& attackObjectD != null)
            {
                AttackJ();
                eneron.SetActive(false);
            }
            
        }
    }

    void AttackH()
    {
        if (attackObjectH != null)
        {
            canAttack = false; // Définit la capacité d'attaquer à faux pendant l'attaque
            attackObjectH.SetActive(true);
            Invoke("DisableAttack", attackDuration);
            venergie = 0;
        }
    }

    void AttackG()
    {
        if (attackObjectG != null)
        {
            canAttack = false;
            attackObjectG.SetActive(true);
            Invoke("DisableAttack", attackDuration);
            venergie = 0;
        }
    }

    void AttackB()
    {
        if (attackObjectB != null)
        {
            canAttack = false;
            attackObjectB.SetActive(true);
            Invoke("DisableAttack", attackDuration);
            venergie = 0;
        }
    }

    void AttackJ()
    {
        if (attackObjectD != null)
        {
            canAttack = false;
            attackObjectD.SetActive(true);
            Invoke("DisableAttack", attackDuration);
            venergie = 0;
        }
    }

    void DisableAttack()
    {
        canAttack = true; // Rétablit la capacité d'attaquer à vrai après la fin de l'attaque

        if (attackObjectH != null)
        {
            attackObjectH.SetActive(false);
        }

        if (attackObjectG != null)
        {
            attackObjectG.SetActive(false);
        }

        if (attackObjectB != null)
        {
            attackObjectB.SetActive(false);
        }

        if (attackObjectD != null)
        {
            attackObjectD.SetActive(false);
        }
    }

    public void EnableAttack()
    {
        canAttack = true;
    }

    public void IncreaseEnergy()
    {
        venergie = 1;
    }

}