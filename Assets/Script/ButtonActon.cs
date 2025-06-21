using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActon : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu"); // заміни на свою назву сцени меню
    }

    // Кнопка "Continue"
    public void ContinueGame()
    {
        SceneManager.LoadScene("Level 2"); // заміни на свою назву сцени 2-го рівня
    }
}
