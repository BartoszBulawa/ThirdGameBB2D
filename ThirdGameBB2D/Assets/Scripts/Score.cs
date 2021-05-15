using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int scorePoints;




    public void Start()
    {
        
    }
   

    public void ScoreUp()
    {
        scorePoints += 10;
    }
    public void ScoreUpOverMonster()
    {
        scorePoints += 20;
    }
    // Update is called once per frame
    public void Update()
    {
        score.text = scorePoints.ToString("0");
      
    }
}
   

