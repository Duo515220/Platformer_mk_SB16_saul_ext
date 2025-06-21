using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTrigger: MonoBehaviour
{
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false); // Ховаємо панель на старті
        Time.timeScale = 1; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TriggerTag")) // Заміни на свій тег
        {
            panel.SetActive(true); // Показати панель
            Time.timeScale = 0;
        }
    }
}

