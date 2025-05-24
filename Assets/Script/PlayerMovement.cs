using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Получаем ось движения (A/D или стрелки)
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Перемещаем игрока по оси X
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
