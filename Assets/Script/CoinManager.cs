using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{

    public int coinCount = 0;          // Количество монет
    public Text coinText;               

    private void Awake()
    {
        UpdateCoinText();   
    }

    // Метод увеличения монет и обновления текста
    public void AddCoin()
    {
        coinCount++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = "" + coinCount.ToString();
    }
}
