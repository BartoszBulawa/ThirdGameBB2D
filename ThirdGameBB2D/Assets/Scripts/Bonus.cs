using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public Text bonus;
    public static int times_left_to_bonus = 5;

    void Start()
    {
        bonus.text = times_left_to_bonus.ToString("0");
    }

    void monsterSkiped()
    {
        times_left_to_bonus--;
        FindObjectOfType<Score>().ScoreUpOverMonster();
        MonsterSkipTrig1. MonsterSkipFirstTrigger = false;
        MonsterSkipTrig2. MonsterSkipSecondTrigger = false;
    }
    

    void Update()
    {
        if (times_left_to_bonus == 0)
        {

            times_left_to_bonus = 5;
        }
        if (MonsterSkipTrig1.MonsterSkipFirstTrigger == true && MonsterSkipTrig2.MonsterSkipSecondTrigger == true)
        {
            monsterSkiped();
        }
        bonus.text = times_left_to_bonus.ToString("0");
    }
    
}
