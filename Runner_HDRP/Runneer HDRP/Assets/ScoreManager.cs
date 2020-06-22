using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Transform Player;

    public static ScoreManager instance;

    public static float score, highscore;

    public Text scoreText, highScoreText;

    
    // Start is called before the first frame update

    

    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = highscore.ToString();
        }
        
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AddScore();
    }


    void AddScore()
    {
        score = ((int)Player.position.z) / 10;

        UpdateHighScore();

        scoreText.text = score.ToString();
    }
    
    public void UpdateHighScore()
    {
        if (score > highscore)
        {
            highscore = score;

            highScoreText.text = highscore.ToString() ;

            PlayerPrefs.SetInt("HighScore", (int) highscore);
        }
    }

    public void ResetScore()
    {
        score = 0;
      
        scoreText.text = score.ToString();
    }
}