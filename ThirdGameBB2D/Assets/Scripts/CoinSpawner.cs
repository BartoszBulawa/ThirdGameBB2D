using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnedCoinPos;

    private GameObject spawnedCoin;

    [SerializeField]
    private GameObject Coin;

    private int randomCoinIndex;

    void Start()
    {
        StartCoroutine(SpawnCoin());
    }

    IEnumerator SpawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            randomCoinIndex = Random.Range(0, spawnedCoinPos.Length);
            spawnedCoin = Instantiate(Coin);
            spawnedCoin.transform.position = spawnedCoinPos[randomCoinIndex].position;
        }
        
    }


}
