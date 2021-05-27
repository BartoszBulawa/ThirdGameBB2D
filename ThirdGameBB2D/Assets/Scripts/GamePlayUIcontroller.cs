using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIcontroller : MonoBehaviour
{
    public void RestartGame()
    {
    reset_all_bonuses();
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void HomeButton()
    {
        reset_all_bonuses();
        SceneManager.LoadScene("MainMenu");
    }
    private void reset_all_bonuses()
    {
        HugeJump.HugeJumpColleced = 0;
        StopMonstersScript.StopMonsterBonusColleced = 0;
        SkeletonHandScrpit.SkeletonHandBonus_Collected = 0;
        Bonus.times_left_to_bonus = 4;
    }
}
