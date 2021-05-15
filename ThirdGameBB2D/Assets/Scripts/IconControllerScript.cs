using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconControllerScript : MonoBehaviour

{
    public GameObject HugeJumpIcon;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HugeJump.HugeJumpColleced>0)
        {
            HugeJumpIcon.SetActive(true);
        }
        else 
        {
            HugeJumpIcon.SetActive(false);
        }


    }
}
