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
    // Update is called once per frame
    public void Update()
    {
        score.text = "Score: " + scorePoints.ToString();
    }
}
