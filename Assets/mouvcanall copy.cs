using UnityEngine;

public class mouvcamsall : MonoBehaviour
{
    public Vector3 cameraTargetPosition; // La position vers laquelle la caméra doit se déplacer
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
        // Calcule la position cible à chaque frame en utilisant l'interpolation linéaire
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraTargetPosition, smoothSpeed * Time.deltaTime);

        // Vérifie si la caméra est proche de la position cible
        if (Vector3.Distance(Camera.main.transform.position, cameraTargetPosition) < 0.1f)
        {
            isMoving = false; // Arrête le déplacement de la caméra une fois qu'elle est suffisamment proche de la position cible
        }
    }
}
