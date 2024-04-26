using UnityEngine;

public class Checkpoint1 : MonoBehaviour
{
    private Vector3 respawnPoint;

    private void Start()
    {
        respawnPoint = transform.position;
        Debug.Log("Le point de réapparition initial est : " + respawnPoint);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Mettre à jour le point de réapparition
            respawnPoint = transform.position;
            Debug.Log("Le point de réapparition a été mis à jour : " + respawnPoint);
        }
    }

    public Vector3 GetRespawnPoint()
    {
        Debug.Log("Le point de réapparition demandé est : " + respawnPoint);
        return respawnPoint;
    }
}
