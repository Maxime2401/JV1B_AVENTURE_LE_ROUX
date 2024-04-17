using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changementdescene : MonoBehaviour
{
    public string Nomdescene;

    public void Allerauniveau()
    {
        SceneManager.LoadScene(Nomdescene);
    }

    void Update()
    {
        // Vérifie si la touche H est enfoncée
        if (Input.GetKeyDown(KeyCode.H))
        {
            // Appelle la méthode Allerauniveau lorsque la touche H est enfoncée
            Allerauniveau();
        }
    }
}
