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
            //Vector3 jump = new Vector3(Other.transform.position.x, Other.transform.position.y + 1, Other.transform.position.z);
            
            //Instantiate(smoke, jump , Quaternion.Euler(-90,0,0));
        }

    }
}
