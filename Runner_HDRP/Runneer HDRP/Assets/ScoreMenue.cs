using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenue : MonoBehaviour
{

    public static ScoreMenue instance;

    public Text highscoremen;

    // Start is called before the first frame update
    private void Awake()
    {
            instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscoremen.text = ScoreManager.highscore.ToString();
    }
}
