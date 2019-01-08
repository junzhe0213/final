using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_move2 : MonoBehaviour
{
    Vector3 speed;

    void FixedUpdate()
    {
        speed = Vector3.right * 4 * Time.deltaTime;
        transform.Translate(speed);

    }
}
