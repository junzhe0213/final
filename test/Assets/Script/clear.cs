using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour
{
    public GameObject clear_sq;
    public GameObject clear_sp;
    // Use this for initialization
    void Start ()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        Instantiate(clear_sq, transform.position, Quaternion.Euler(-180, 0, 0));
        Instantiate(clear_sp, pos, Quaternion.Euler(-90, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
