using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_move : MonoBehaviour
{
    Vector3 speed;

    void FixedUpdate()
    {
        speed = Vector3.left * 4 * Time.deltaTime;
        transform.Translate(speed);

    }
}
