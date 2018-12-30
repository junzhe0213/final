using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject player;
	
	void Update ()
    {
		if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.Space))
        {
            Instantiate(player, transform.position,transform.rotation);

        }
	}
}
