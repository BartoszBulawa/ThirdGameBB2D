using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHand_Spawner_Script : MonoBehaviour
{
    [SerializeField]
    private Transform[] SpawnedHandPos;

    [SerializeField]
    private GameObject SkeletonHand;

    private GameObject Spawned_SkeletonHand;

    private int randomSpawnPos;

   

    public static bool SkeletonHand_Bonus_Item_Has_Been_Collected = false;
    private void Update()
    {
        if (SkeletonHand_Bonus_Item_Has_Been_Collected)
        {
            SkeletonHand_Bonus_Item_Has_Been_Collected = false;
            Spawn_the_Skeleton_Hand();
        }
    }

    private void Spawn_the_Skeleton_Hand()
    {
            randomSpawnPos = Random.Range(0, SpawnedHandPos.Length);
            Spawned_SkeletonHand = Instantiate(SkeletonHand);
            Spawned_SkeletonHand.transform.position = SpawnedHandPos[randomSpawnPos].position;
       
    }
}
