using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed_change : MonoBehaviour
{
    private GameObject ball;
    private player player;
    public int sp;

    void Start ()
    {
        ball = GameObject.FindGameObjectWithTag("Player");
        player = ball.GetComponent<player>();
    }
	
	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.speed = sp;
        }
    }
}
