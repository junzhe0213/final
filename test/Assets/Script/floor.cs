using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public GameObject smoke;

    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "Player")
        {
        }

    }
}
