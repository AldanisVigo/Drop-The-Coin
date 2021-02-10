using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCoins : MonoBehaviour
{

    [SerializeField] GameObject coin;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Button dropCoinBtn;

    private void Start()
    {
        dropCoinBtn.onClick.AddListener(dropCoin);
        for(var i = 0; i < 10; i++)
        {
            dropCoin();
        }
    }

    private void dropCoin()
    {
        print("Instantiating Coin");
        var randomX = spawnPoint.position.x - 10f + Random.Range(0f, 20f);
        Vector3 newPos = new Vector3(randomX, spawnPoint.position.y, spawnPoint.position.z);
        Instantiate(coin, newPos, spawnPoint.rotation);
    }
}
