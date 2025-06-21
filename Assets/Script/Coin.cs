using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinManager, playerHp;
    void Start()
    {
        coinManager = GameObject.Find("CoinManager");
        playerHp = GameObject.Find("player");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Увеличиваем счетчик монет через CoinManager
            coinManager.GetComponent<CoinManager>().AddCoin();
            playerHp.GetComponent<PlayerHealth>().AddHp();

            // Уничтожаем монету
            Destroy(gameObject);
        }
    }
}