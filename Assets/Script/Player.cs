using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D Rb;
    private Vector2 playerDirection;
    public float jumpForce;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }
    private void FixedUpdate()
    {
        Rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
   