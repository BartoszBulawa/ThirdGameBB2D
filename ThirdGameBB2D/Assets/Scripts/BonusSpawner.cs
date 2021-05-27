using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] SpawnedBonusItemPos;

    [SerializeField]
    private GameObject[] BonusItems;

    private GameObject SpawnedBonusItem;

    private int randomItemIndex;
    private int randomItemPos;


    private void Update()
    {
        CheckIsBonusAvailable();
    }

    private void CheckIsBonusAvailable()
    { if (Bonus.times_left_to_bonus == 0)
        {
            randomItemIndex = Random.Range(0, BonusItems.Length);
            randomItemPos = Random.Range(0, SpawnedBonusItemPos.Length);
            SpawnedBonusItem = Instantiate(BonusItems[randomItemIndex]);
            SpawnedBonusItem.transform.position = SpawnedBonusItemPos[randomItemPos].position;
            Bonus.times_left_to_bonus = 4;
        }
    } 
}
