using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip soundClip; // Son à jouer
    private AudioSource audioSource; // Référence au composant AudioSource

    private void Start()
    {
        // Récupérer le composant AudioSource attaché à cet objet ou à un parent
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogWarning("Pas de composant AudioSource trouvé. Assurez-vous d'avoir attaché un AudioSource à cet objet ou à un parent.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifier si le joueur entre en collision avec ce trigger
        if (other.CompareTag("Player"))
        {
            // Jouer le son
            if (audioSource != null && soundClip != null)
            {
                audioSource.PlayOneShot(soundClip);
            }
        }
    }
}
