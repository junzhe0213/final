using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject spark;

    void Start ()
    {
        Instantiate(spark, transform.position, Quaternion.Euler(180, 0, 0));
    }
}
