using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public bool IsGround;
    //public bool gameover;
    //public bool restart;

    //public Text gameover_text;
    //public Text restart_text;

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
        if (Input.GetKey(KeyCode.UpArrow) && IsGround || Input.GetKey(KeyCode.Space) && IsGround)
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
                Instantiate(smoke, transform.position, Quaternion.Euler(-90, 0, 0));
            }
        }
        else
        {
            moveY += gravity * Vector3.down * Time.deltaTime;
        }
    }
}
