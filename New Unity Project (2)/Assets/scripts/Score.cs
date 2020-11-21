using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    BallControlller BallControlller;
    [SerializeField] Text Scoretex,highscoretext;
    int score, highscore;
    // Start is called before the first frame update
    void Start()
    {
        BallControlller = GameObject.FindGameObjectWithTag("Player").GetComponent<BallControlller>();
       

        highscore = PlayerPrefs.GetInt("Highscore", highscore);

    }

    // Update is called once per frame
    void Update()
    {
        score = BallControlller.score;
        Scoretex.text = score.ToString();
        highscoretext.text = highscore.ToString();

        if(score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }
}
