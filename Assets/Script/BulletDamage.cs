using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage = 1; // ставимо 1

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Якщо куля вдаряє гравця
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            // Знищити кулю після зіткнення
            Destroy(gameObject);
        }
    }
}
