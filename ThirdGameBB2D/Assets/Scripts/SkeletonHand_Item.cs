using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHand_Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SkeletonHandScrpit.SkeletonHandBonus_Collected++;
            SkeletonHand_Spawner_Script.SkeletonHand_Bonus_Item_Has_Been_Collected = true;
            Destroy(gameObject);
        }
    }
   
}
