using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    public GameObject player;

    public float damping = 1;

    Vector3 offset;

	void Start ()
    {

        //Camera跟角色的距離
        offset = transform.position - player.transform.position;
    }
	
	void Update ()
    {

        //smooth
        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;
    }
}
