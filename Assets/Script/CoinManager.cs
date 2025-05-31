using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coinCount = 0;          // Количество монет
    private Text coinText;               

    private void Awake()
    {
        // Реализация паттерна Singleton, чтобы можно было обращаться к CoinManager из других скриптов
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Метод увеличения монет и обновления текста
    public void AddCoin()
    {
        coinCount++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = "Монеты: " + coinCount.ToString();
    }
}
