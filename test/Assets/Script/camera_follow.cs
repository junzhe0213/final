using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
    //public GameObject player;
    public float margin;

    private Vector3 offset;

    public Transform player;
    

	void Start ()
    {
        //Camera跟角色的距離
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
        if(player != null)
        if (CheckMargin())
        {
            var targetPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z - margin);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.25f);
        }
    }

    bool CheckMargin()
    {
        return Mathf.Abs(transform.position.z - player.transform.position.z) >= margin;
    }



}
