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
     public float total;


    void Start()
    {
        score =0;

    }


    void Update()
    {

        score +=1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();

        highscore =(int)score;
        scoreText.text =" " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        PlayerPrefs.SetInt("score", highscore);

        highscoreText.text = " " + PlayerPrefs.GetInt("score").ToString(); 
       

            
           
    } 

}
