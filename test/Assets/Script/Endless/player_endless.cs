using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_endless : MonoBehaviour
{
    public bool IsGround;

    private Vector3 velocity = Vector3.zero;
    private Vector3 moveX;
    private Vector3 moveY;

    public float speed = 4;

    public int count;

    public GameObject smoke;

    private void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score")
        {
            count = count + 1;
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
        move();
        velocity = moveX + moveY + Vector3.forward * speed * Time.deltaTime;
        transform.Translate(velocity);
    }

    void move()
    {
        moveX = Input.GetAxis("Horizontal") * 6 * Time.deltaTime * Vector3.right;
    }
}
