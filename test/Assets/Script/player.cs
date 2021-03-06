﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public bool IsGround;

    private Vector3 velocity = Vector3.zero;
    private Vector3 moveX;
    private Vector3 moveY;

    public float speed = 4;
    private float jumpforce = 7f;
    private float gravity = 0.2F;

    public int count;

    public GameObject smoke;
    public GameObject sc;

    public AudioSource jumping;
    public AudioSource score;

    private void Start()
    {
        count = 0;
        jumping = gameObject.GetComponent<AudioSource>();
        score = sc.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "score")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score.Play();
        }
    }

    void OnCollisionStay(Collision Other)
    {
        if (Other.gameObject.tag == "floor")
        {
            IsGround = true;
            moveY = Vector3.zero;
        }
        if (Other.gameObject.tag == "floor")
        {
            IsGround = true;
            moveY = Vector3.zero;
        }

    }

    void FixedUpdate()
    {
        Move();
        Jumping();
        velocity = moveX + moveY + Vector3.forward * speed * Time.deltaTime;
        transform.Translate(velocity);
    }

    void Move()
    {
        moveX = Input.GetAxis("Horizontal") * 6 * Time.deltaTime * Vector3.right;
    }

    void Jumping()
    {
        if (Input.GetKey(KeyCode.UpArrow) && IsGround || Input.GetKey(KeyCode.Space) && IsGround)
        {
            moveY = jumpforce * Time.deltaTime * Vector3.up;
            jumping.Play();
            if (transform.position.y > 0.4)
            {
                IsGround = false;
                Debug.Log("456");
            }
            if (transform.position.y < 0.6)
            {
                Debug.Log("123");
                Instantiate(smoke, transform.position, Quaternion.Euler(-90, 0, 0));
            }
        }
        else
        {
            moveY += gravity * Vector3.down * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftAlt))
            {
            count = 3;
            }
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.position = new Vector3(0, 0.5f, 137);
        }
    }
}
