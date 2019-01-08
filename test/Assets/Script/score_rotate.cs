using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_rotate : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(70 * Time.deltaTime, 60 * Time.deltaTime, 50 * Time.deltaTime);
    }
}
