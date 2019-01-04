using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_move : MonoBehaviour
{
    Vector3 speed;

    void FixedUpdate()
    {
        speed = Vector3.left * 6 * Time.deltaTime;
        transform.Translate(speed);

    }
}
