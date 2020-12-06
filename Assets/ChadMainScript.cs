﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChadMainScript : MonoBehaviour
{

    public enum State { walking,idle,crouch,jump,dead}
    public enum Direction { Left = -1, Right = 1}
    public Direction ChadDirection;
    public State ChadState;
    public Rigidbody2D rb;
    public float WalkSpeed;
    public float WalkAcceleration;
    public float jumpHeight;
    Vector2 jump;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector2(0, jumpHeight);   
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.D))
        {
            ChadState = State.walking;
            ChadDirection = Direction.Right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            ChadState = State.walking;
            ChadDirection = Direction.Left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            ChadState = State.crouch;
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S))
        {
            ChadState = State.idle;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump);
        }


        if (ChadState == State.walking)
        {
            Vector3 WalkingVector = new Vector3(transform.right.x * WalkSpeed * (int)ChadDirection,0,0);
            rb.velocity = new Vector2(WalkingVector.x, rb.velocity.y);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
        
    }

    //bruh

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }
}
