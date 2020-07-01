using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    static bool gamestart;
    public bool hasStarted;
    public PortalTeleporter teleported;
    public failing hasFailed;

    void Update()
    {
        Debug.Log(gamestart);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            hasStarted = true;
            gamestart = true;
        }

        if(gamestart == true)
        {
            hasStarted = true;
        }

        if (hasFailed.failed)
        {
            gamestart = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            gamestart = false;
        }

        
   
    }
}
