using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public Text bonus;
    public static int times_left_to_bonus = 4;

    void Start()
    {
        bonus.text = times_left_to_bonus.ToString("");
    }

    void monsterSkiped()
    {
        times_left_to_bonus--;
        FindObjectOfType<Score>().Reward_for_skiped_monster();
        MonsterSkipTrig1. MonsterSkipFirstTrigger = false;
        MonsterSkipTrig2. MonsterSkipSecondTrigger = false;
    }
    
    void Update()
    {
        
        if (MonsterSkipTrig1.MonsterSkipFirstTrigger == true && MonsterSkipTrig2.MonsterSkipSecondTrigger == true)
        {
            monsterSkiped();
        }
        bonus.text = times_left_to_bonus.ToString("");
    }
    
}
