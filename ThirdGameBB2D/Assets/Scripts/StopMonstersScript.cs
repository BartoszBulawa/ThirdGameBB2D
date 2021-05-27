using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMonstersScript : MonoBehaviour
{
    public static int StopMonsterBonusColleced = 0;


    public int StopMonstersDuration;

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
            if (Player.Player_is_stopping_Monsters)
            {
                yield return new WaitForSeconds(StopMonstersDuration);
                Player.Player_is_stopping_Monsters = false;
                StopMonsterBonusColleced--;
            }
        }
          
    }
  
    private void Start()
    {
        
      StartCoroutine(MonstersStop());
    }
}
