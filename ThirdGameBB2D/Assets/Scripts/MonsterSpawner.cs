using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;
    //new
    [SerializeField]
    private Transform [] spawnedCoinPos;
  
    [SerializeField]
    private GameObject[] BonusItems;


    private GameObject SpawnedBonusItem;


    private GameObject spawnedMonster;
    //new
    
    private GameObject spawnedCoin;
    //new
    [SerializeField]
    private GameObject Coin;

    [SerializeField]
    private Transform[] SpawnedBonusItemPos;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    private int randomItemIndex;
    //new
    private int randomCoinIndex;
    private int randomItemPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while(true){
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);

            randomItemIndex = Random.Range(0, BonusItems.Length);
            //new
            randomCoinIndex = Random.Range(0, spawnedCoinPos.Length);

            randomSide = Random.Range(0, 2);

            randomItemPos = Random.Range(0, SpawnedBonusItemPos.Length);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);
            //new
            spawnedCoin = Instantiate(Coin);

            


            //new
            spawnedCoin.transform.position = spawnedCoinPos[randomCoinIndex].position;

            if (Bonus.times_left_to_bonus == 4)
            {
                SpawnedBonusItem = Instantiate(BonusItems[randomItemIndex]);
                SpawnedBonusItem.transform.position = SpawnedBonusItemPos[randomItemPos].position;
                Bonus.times_left_to_bonus--;
            }

            if (randomSide  == 0)
            {
                spawnedMonster.transform.position = leftPos.position;

                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 9);

            }
            else
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 9);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
