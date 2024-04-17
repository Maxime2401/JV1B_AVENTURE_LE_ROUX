using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class regesolaire : MonoBehaviour
{
    private bool canrege = false; // Declare the boolean variable

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canrege)
        {
            // Perform actions when canrege is true
        }
    }    
    
    public void EnableRege()
    {
        canrege = true;
    }

}
