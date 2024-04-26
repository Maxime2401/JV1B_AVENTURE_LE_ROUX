using UnityEngine;

public class GameManagera : MonoBehaviour
{
    public static GameManagera Instance { get; private set; }
    private Vector3 lastCheckpointPosition;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void SetCheckpointPosition(Vector3 position)
    {
        lastCheckpointPosition = position;
    }

    public void RespawnPlayer(GameObject player)
    {
        if (player != null)
        {
            barvi barvi = player.GetComponent<barvi>();
            if (barvi == null)
            {
                player.transform.position = lastCheckpointPosition;
                Debug.Log("Le joueur est réapparu au dernier checkpoint !");
            }
            else
            {
                Debug.LogWarning("Le GameObject du joueur ne contient pas de composant barvi !");
            }
        }
        else
        {
            Debug.LogWarning("Le GameObject du joueur est null !");
        }
    }
}
