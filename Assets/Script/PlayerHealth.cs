
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public Text livesText;

    public GameObject deathPanel; // Панель смерти

    void Start()
    {
        currentHealth = maxHealth;
        deathPanel.SetActive(false); // Скрываем панель в начале
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        livesText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    void Die()
    {
        // Показываем панель смерти
        deathPanel.SetActive(true);

        // Можно отключить управление игроком здесь
        // Например, если у тебя есть скрипт PlayerMovement:
        // GetComponent<PlayerMovement>().enabled = false;
    }

    // Метод для кнопки "Начать сначала"
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMenu()
    {
                SceneManager.LoadScene("Menu");

    }

}
