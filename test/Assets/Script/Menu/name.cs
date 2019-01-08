using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    private float smooth = 15;
    private Vector3 velocity = Vector3.zero;
    private Vector3 moveY;

    void FixedUpdate ()
    {
        if(transform.position.y >= 900)
        {
            Debug.Log("down");
            moveY = Vector3.down * 1 * Time.deltaTime;
            velocity = moveY += smooth * Vector3.down * Time.deltaTime;
        }
        if (transform.position.y <= 880)
        {
            velocity = moveY += smooth * Vector3.up * Time.deltaTime;
        }
        transform.Translate(velocity);
    }
}
