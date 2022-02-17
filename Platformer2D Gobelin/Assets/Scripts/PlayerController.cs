using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    public float jumpSpeed = 500f;
    public bool isGrounded;
    public bool isWalledLeft;
    public bool isWalledRight;

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float horizontalMov = x * speed;
        rb.velocity = new Vector3(horizontalMov, rb.velocity.y, 0);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isWalledLeft)
        {
            rb.AddForce(Vector3.up * jumpSpeed * 0.8f);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isWalledRight)
        {
            rb.AddForce(Vector3.up * jumpSpeed * 0.8f);
        }
    }
}
