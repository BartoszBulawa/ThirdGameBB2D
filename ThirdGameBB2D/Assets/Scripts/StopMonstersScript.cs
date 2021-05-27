using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMonstersScript : MonoBehaviour
{
    public static int StopMonsterBonusColleced = 0;
    public int StopMonstersDuration;
    public static bool Player_is_stopping_Monsters = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StopMonsterBonusColleced++;
            Destroy(gameObject);
        }
    }
    IEnumerator MonstersStop()
    {
        while(true)
        {
            yield return new WaitForSeconds(StopMonstersDuration);
           StopMonstersDuration = 2;
            if (Player_is_stopping_Monsters)
            {
                StopMonsterBonusColleced--;
                yield return new WaitForSeconds(StopMonstersDuration);
                Player_is_stopping_Monsters = false;
            }
        }
    }
  
    private void Start()
    {
      StartCoroutine(MonstersStop());
    }
}
