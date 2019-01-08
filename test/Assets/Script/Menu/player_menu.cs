using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_menu : MonoBehaviour
{
    public bool IsGround;

    private Vector3 velocity = Vector3.zero;
    private Vector3 moveX;
    private Vector3 moveY;

    private float jumpforce = 8f;
    private float gravity = 0.2F;

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

    void FixedUpdate ()
    {
        moveX = Input.GetAxis("Horizontal") * 6 * Time.deltaTime * Vector3.right;
        if (Input.GetKey(KeyCode.UpArrow) && IsGround || Input.GetKey(KeyCode.Space) && IsGround)
        {
            moveY = jumpforce * Time.deltaTime * Vector3.up;
            gameObject.GetComponent<AudioSource>().Play();
            if (transform.position.y > 0.4)
            {
                IsGround = false;
            }
            if (transform.position.y < 1)
            {
                Instantiate(smoke, transform.position, Quaternion.Euler(-90, 0, 0));
            }
        }
        else
        {
            moveY += gravity * Vector3.down * Time.deltaTime;
        }
        velocity = moveX + moveY;
        transform.Translate(velocity);
    }
}
