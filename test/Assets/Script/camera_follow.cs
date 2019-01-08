using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public float margin;

    private Vector3 offset;

    public Transform player;

    void Update()
    {
        if (player != null && CheckMargin())
        {
            var distance = new Vector3(transform.position.x, transform.position.y, player.transform.position.z - margin);
            transform.position = Vector3.MoveTowards(transform.position, distance, 10f);
        }
    }

    //Camera跟Player的距離
    bool CheckMargin()
    {
        return Mathf.Abs(transform.position.z - player.transform.position.z) >= margin;
    }



}
