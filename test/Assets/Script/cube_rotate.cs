using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotate : MonoBehaviour {

    public GameObject explosion;

    void FixedUpdate ()
    {
        transform.Rotate(30 * Time.deltaTime , 30 * Time.deltaTime , -30 * Time.deltaTime);	
	}

    void OnCollisionStay(Collision Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Instantiate(explosion, Other.transform.position, Other.transform.rotation);
        }
        Destroy(Other.gameObject);
    }
}
