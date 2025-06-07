using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform player;               // Посилання на гравця
    public GameObject bulletPrefab;        // Префаб кулі
    public Transform firePoint;            // Точка вильоту кулі
    public float bulletSpeed = 5f;         // Швидкість кулі
    public float shootingInterval = 2f;    // Інтервал між пострілами
    public float shootingRange = 8f;       // Дистанція стрільби

    private float shootTimer;

    void Update()
    {
        if (player == null)
            return;

        // Відстань до гравця
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= shootingRange)
        {
            shootTimer += Time.deltaTime;

            if (shootTimer >= shootingInterval)
            {
                ShootAtPlayer();
                shootTimer = 0f;
            }
        }
    }

    void ShootAtPlayer()
    {
        // Створюємо кулю
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Обчислюємо напрямок у 2D
        Vector2 direction = (player.position - firePoint.position).normalized;

        // Даємо кулі швидкість
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * bulletSpeed;
        }

        // Знищити кулю через 5 сек
        Destroy(bullet, 5f);
    }
}

