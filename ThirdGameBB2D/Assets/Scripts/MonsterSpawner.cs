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

    private GameObject spawnedMonster;
    //new
    [SerializeField]
    private GameObject spawnedCoin;
    //new
    [SerializeField]
    private GameObject Coin;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    //new
    private int randomCoinIndex;

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
            //new
            randomCoinIndex = Random.Range(0, spawnedCoinPos.Length);

            randomSide = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);
            //new
            spawnedCoin = Instantiate(Coin);
            //new
            spawnedCoin.transform.position = spawnedCoinPos[randomCoinIndex].position;

            if (randomSide  == 0)
            {
                spawnedMonster.transform.position = leftPos.position;

                spawnedMonster.GetComponent<Monster>().speed = Random.Range(5, 11);

            }
            else
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(5, 11);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
