using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HugeJumpsLeftScript : MonoBehaviour
{
    public Text HugeJumpScreenCounter;
  
    void Update()
    {
        HugeJumpScreenCounter.text = HugeJump.HugeJumpColleced.ToString("0");
    }
}
