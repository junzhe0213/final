using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cones : MonoBehaviour
{
    public GameObject explosion;

    void Update()
    {
        Destroy(gameObject, 5);
    }
    void OnCollisionStay(Collision Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Instantiate(explosion, Other.transform.position, Other.transform.rotation);
        }
        Destroy(Other.gameObject);
        Destroy(gameObject, 1.5f);
    }
}
