using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSkipTrig2 : MonoBehaviour

{
    public static bool MonsterSkipSecondTrigger = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            MonsterSkipSecondTrigger = true;
        }
    }

}
