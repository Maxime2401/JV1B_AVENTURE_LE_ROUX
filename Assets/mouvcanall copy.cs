using UnityEngine;

public class mouvcamsall : MonoBehaviour
{
    public Transform targetObject; // L'objet dont la position sera utilisée comme cible pour le déplacement de la caméra
    public float smoothSpeed = 2.0f; // Vitesse de lissage du mouvement

    private bool isMoving = false; // Indique si la caméra est en mouvement

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isMoving = true; // Démarre le déplacement de la caméra
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            MoveCameraToTargetPosition(); // Déplace la caméra progressivement vers la position cible

        }

    }

    private void MoveCameraToTargetPosition()
    {
        if (targetObject != null)
        {
            // Calcule la position cible à chaque frame en utilisant l'interpolation linéaire
            Vector3 targetPosition = targetObject.position;
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, targetPosition, smoothSpeed * Time.deltaTime);

            // Vérifie si la caméra est proche de la position cible
            if (Vector3.Distance(Camera.main.transform.position, targetPosition) < 0.1f)
            {
                isMoving = false; // Arrête le déplacement de la caméra une fois qu'elle est suffisamment proche de la position cible
            }
        }
        else
        {
            Debug.LogWarning("Aucun objet cible assigné pour le déplacement de la caméra.");
            isMoving = false; // Arrête le déplacement de la caméra si aucun objet cible n'est assigné
        }
    }
}
