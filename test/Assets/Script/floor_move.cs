using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_move : MonoBehaviour
{
    public GameObject smoke;

    void OnCollisionStay(Collision Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Instantiate(smoke, Other.transform.position, Other.transform.rotation);
        }

    }
}
