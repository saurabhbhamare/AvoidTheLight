using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public float survivalTime;
    public float scoreIncreasePerSecond;
    public float score;
    
  //  public float score;
    
    void Start()
    {
        survivalTime = 0.0f;
        scoreIncreasePerSecond = 1.0f;
        score = 0f;
        IncreaseScore(0);
    }
    void Update()
    {
        SurvivalTIme();     
    }
    public void IncreaseScore( float addScore)
    {
        Debug.Log("called increasescore");
        score += addScore;
        scoreText.text = "Score - " + score;
       
    }
    public void SurvivalTIme()
    {
        timerText.text = "Time - " + (int)survivalTime;
        survivalTime += scoreIncreasePerSecond * Time.deltaTime;
    }
    
}
