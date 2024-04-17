using UnityEngine;
using System.Collections;

public class barvi : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public int health;
    public float invincibleflashdelay = 0.1f;
    public bool invincible = false;

    public SpriteRenderer graphics;
    public HealthBar HealthBar;

    public Vector3 teleportPosition; // position de téléportation du joueur

    void Start()
    {
        currentHealth = maxHealth;  
        HealthBar.SetMaxHealth(maxHealth);
    }

    void Update()//teste
    {
        if (Input.GetKeyDown(KeyCode.H))
        {   
            TakeDamage(1);
        }
    }
    
    public void TakeEnergie(int energie)
    {
        currentHealth += energie;
     // Vérifier si la santé actuelle dépasse la santé maximale
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; // Réinitialiser la santé à la valeur maximale
        }
        HealthBar.SetHealth(currentHealth);
    }

    
    public void TakeDamage(int damage)
    {       
        if (!invincible)
        {
            currentHealth -= damage;
            HealthBar.SetHealth(currentHealth);
            invincible = true;
            StartCoroutine(invincibleFrash());
            StartCoroutine(HandinvincibleDelay());

            if (currentHealth <= 0)
            {
                TeleportPlayer(); // téléportation si la santé est <= 0
            }
        }
    }

    public IEnumerator invincibleFrash()// permet de faire clignoter le joueur lors qu'il prend des dégats
    {
        while (invincible)
        {
            graphics.color =new Color(1f, 1f ,1f, 0f);
            yield return new WaitForSeconds (invincibleflashdelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds (invincibleflashdelay);
        }
    }

    public IEnumerator HandinvincibleDelay()
    {
        yield return new WaitForSeconds(0.3f);//temps d'invincibiliter
        invincible = false;
    }

    void TeleportPlayer()
    {
        transform.position = teleportPosition; 
        currentHealth = maxHealth; // réinitialiser la vie du joueur
        HealthBar.SetHealth(currentHealth); 
    }
}
