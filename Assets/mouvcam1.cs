using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Référence au transform du personnage à suivre
    public float smoothSpeed = 0.125f; // Vitesse de lissage du mouvement

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position; // Position désirée de la caméra (égale à la position du personnage)
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Interpolation linéaire pour un mouvement fluide
            transform.position = smoothedPosition; // Déplacement de la caméra vers la nouvelle position lissée
        }
    }
}
