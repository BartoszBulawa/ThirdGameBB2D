using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int scorePoints;


    public void ScoreUp()
    {
        scorePoints += 10;
    }
    public void ScoreUpOverMonster()
    {
        scorePoints += 20;
    }
    public void Reward_for_destroyed_monser()
    {
        scorePoints += 100;
    }

    public void Update()
    {
        score.text = scorePoints.ToString("0");
    }
}
   

