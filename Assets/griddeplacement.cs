using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de déplacement du joueur
    public float tailleCase = 1f; // Taille d'une case dans la grille
    private bool enDeplacement = false; // Indique si le joueur est en cours de déplacement
    private Vector3 destination; // Destination du joueur
  
    private bool murGauche = false;
    private bool murDroit = false;
    private bool murHaut = false;
    private bool murBas = false;
    
    public Collider2D captgauche;
    public Collider2D captdroit;
    public Collider2D capthaut;
    public Collider2D captbas;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wallgauche"))
        {
            murGauche = true;
        }
        else if (other.CompareTag("Walldroit"))
        {
            murDroit = true;
        }
        else if (other.CompareTag("Wallhaut"))
        {
            murHaut = true;
        }
        else if (other.CompareTag("Wallbas"))
        {
            murBas = true;
        }
    }    


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wallgauche"))
        {
            murGauche = false;
        }
        else if (other.CompareTag("Walldroit"))
        {
            murDroit = false;
        }
        else if (other.CompareTag("Wallhaut"))
        {
            murHaut = false;
        }
        else if (other.CompareTag("Wallbas"))
        {
            murBas = false;
        }
        if (other.CompareTag("Genera"))
        {
            barvi barvi = transform.GetComponent<barvi>();
            barvi.TakeEnergie(1);
        }
    }

    void Update()
    {
        if (!enDeplacement)
        {
            // Déplacement horizontal
            if (Input.GetKeyDown(KeyCode.LeftArrow)&& !murGauche)
            {
                barvi barvi = transform.GetComponent<barvi>();
                barvi.TakeDamage(1);//-1 énergie
                Deplacer(-1f, 0f);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)&&!murDroit)
            {
                barvi barvi = transform.GetComponent<barvi>();
                barvi.TakeDamage(1);
                Deplacer(1f, 0f);
            }
            
            // Déplacement vertical
            if (Input.GetKeyDown(KeyCode.UpArrow)&& !murHaut)
            {
                barvi barvi = transform.GetComponent<barvi>();
                barvi.TakeDamage(1);                
                Deplacer(0f, 1f);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)&& !murBas)
            {
                barvi barvi = transform.GetComponent<barvi>();
                barvi.TakeDamage(1);
                Deplacer(0f, -1f);
            }
        }
    }

    void Deplacer(float deltaX, float deltaY)
    {
        if (!enDeplacement)
        {
            Vector3 nouvellePosition = transform.position + new Vector3(deltaX * tailleCase, deltaY * tailleCase, 0f);
            destination = nouvellePosition;
            enDeplacement = true;
        }
    }

    void FixedUpdate()
    {
        if (enDeplacement)
        {
            float distance = Vector3.Distance(transform.position, destination);
            if (distance > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, destination, vitesseDeplacement * Time.fixedDeltaTime);
            }
            else
            {
                enDeplacement = false;
            }
        }
    }
}
