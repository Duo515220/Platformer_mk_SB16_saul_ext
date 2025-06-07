using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinManager;
    void Start()
    {
        coinManager = GameObject.Find("CoinManager");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Увеличиваем счетчик монет через CoinManager
            coinManager.GetComponent<CoinManager>().AddCoin();

            // Уничтожаем монету
            Destroy(gameObject);
        }
    }
}