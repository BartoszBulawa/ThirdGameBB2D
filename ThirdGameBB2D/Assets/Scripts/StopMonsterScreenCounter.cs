using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopMonsterScreenCounter : MonoBehaviour
{
    public Text StopMonstersBonusScreenCounter;
    void Update()
    {
        StopMonstersBonusScreenCounter.text = StopMonstersScript.StopMonsterBonusColleced.ToString("0");
    }
}
