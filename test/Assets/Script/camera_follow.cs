using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    public GameObject player;

    public Vector3 offset;

    

	void Start ()
    {

        //Camera跟角色的距離
        offset = transform.position - player.transform.position;
    }
	
	void Update ()
    {
        //smooth
        transform.position = player.transform.position + offset;

    }
}
