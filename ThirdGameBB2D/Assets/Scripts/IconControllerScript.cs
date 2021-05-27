using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconControllerScript : MonoBehaviour

{
    public GameObject HugeJumpIcon;
    public GameObject StopTheMonsterIcon;
    public GameObject SkeletonHand_Icon;
    

    void Update()
    {
        if (HugeJump.HugeJumpColleced>0)
            HugeJumpIcon.SetActive(true);
        else 
            HugeJumpIcon.SetActive(false);

        if (StopMonstersScript.StopMonsterBonusColleced > 0)
            StopTheMonsterIcon.SetActive(true);
        else
            StopTheMonsterIcon.SetActive(false);
        if (SkeletonHandScrpit.SkeletonHandBonus_Collected > 0)
            SkeletonHand_Icon.SetActive(true);
        else
            SkeletonHand_Icon.SetActive(false);
    }
}
