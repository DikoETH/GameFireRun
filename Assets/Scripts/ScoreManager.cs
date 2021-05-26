using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    private float score;
    int highscore;
    public Text scoreText2;
    private float score2;


    void Start()
    {
        score =0;
        score2 =0;

    }


    void Update()
    {

        score +=1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();

        score2 +=1 * Time.deltaTime;
        scoreText2.text = ((int)score2).ToString();

        highscore =(int)score;
        scoreText.text =" " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        PlayerPrefs.SetInt("score", highscore);

        highscoreText.text = " " + PlayerPrefs.GetInt("score").ToString();     




    } 

}
