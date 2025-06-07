using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;    // Максимальне HP
    public int currentHealth;      // Поточне HP

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Функція для отримання урону
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Гравець отримав урон: " + damage + " | HP залишилось: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Гравець помер!");
        Destroy(gameObject);
    }
}
