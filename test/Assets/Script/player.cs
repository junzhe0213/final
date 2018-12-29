using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool IsGround;

    private Vector3 velocity = Vector3.zero;
    private Vector3 moveX;
    private Vector3 moveY;

    public float speed = 4;
    public float jumpforce = 4f;
    public float gravity = 0.01F;

    public GameObject smoke;

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
        jumping();
        velocity = moveX + moveY + Vector3.forward * 4 * Time.deltaTime;
        //velocity = moveX + moveY;
        transform.Translate(velocity);
    }

    void move()
    {
        moveX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime * Vector3.right;
    }

    void jumping()
    {
        if (Input.GetKey(KeyCode.UpArrow) && IsGround)
        {
            moveY = jumpforce * Time.deltaTime * Vector3.up;
            if (transform.position.y > 0.4)
            {
                IsGround = false;
                Debug.Log("456");
            }
            if (transform.position.y < 0.6)
            {
                Debug.Log("123");
                //var jump = new Vector3(transform.position.x , transform.position.y , transform.position.z);
               // Instantiate(smoke, jump , transform.rotation);
            }
        }
        else
        {
            moveY += gravity * Vector3.down * Time.deltaTime;
        }
    }
}
