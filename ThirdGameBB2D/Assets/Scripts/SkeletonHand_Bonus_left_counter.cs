using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonHand_Bonus_left_counter : MonoBehaviour
{
    public Text ScreenCounter;

    private void Update()
    {
        ScreenCounter.text = SkeletonHandScrpit.SkeletonHandBonus_Collected.ToString("");
    }


}
