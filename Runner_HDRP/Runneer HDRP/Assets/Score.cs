using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform Player;
    public Text scoreText;
    public Text scoreHigh;

    //public int score = scoreText.ToString("0");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
        //UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        /*if (scoreText > scoreHigh)
        {
            scoreHigh = scoreText;
        }
        */
    }
}
