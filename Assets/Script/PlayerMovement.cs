using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector3 originalScale;

    public Transform groundCheck;         // Точка проверки земли
    public float groundCheckRadius = 0.2f;
    public LayerMask whatIsGround;        // Какие объекты считаются землёй
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Устанавливаем размер персонажа
        transform.localScale = new Vector3(4.5f, 3.5f, 1f);

        // Сохраняем этот размер как оригинальный
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Получаем направление по горизонтали
        movement.x = Input.GetAxisRaw("Horizontal");

        // Поворот
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }

        // Проверка нажатия кнопки прыжка и возможности прыгнуть
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        // Двигаем объект
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }


    void OnDrawGizmosSelected()
    {
        if (groundCheck == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}