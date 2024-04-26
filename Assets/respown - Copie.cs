using UnityEngine;

public class Checkpointtest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCheckpointPosition(transform.position);
            Debug.Log("Checkpoint atteint !");
        }
    }
}
