using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	void FixedUpdate()
    {
        transform.Translate(Vector3.forward * 4 * Time.deltaTime);
    }
}
