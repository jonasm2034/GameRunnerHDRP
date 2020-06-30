using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleFo : MonoBehaviour
{
    float timer;
    
    void Start()
    {

        //this.transform.position;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            transform.position = new Vector3(100, 100, 100);
        }
    }


}
