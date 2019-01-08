using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirgger_gole : MonoBehaviour
{
    public GameObject ball;
    public player player;

    void Start()
    {
        player = ball.GetComponent<player>();   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.speed = 0;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
