using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failing : MonoBehaviour
{
    public Transform player;
    public SpawnLevel1 lowestY;
    public bool failed;


    void Update()
    {
        if (player.position.y < lowestY.lowest -160)
        {
            SceneManager.LoadScene(1);
        }
        if (player.position.y < lowestY.lowest - 150)
        {
            failed = true;
        }

    }
}
