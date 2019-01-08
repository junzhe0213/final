using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_stop : MonoBehaviour
{
    public GameObject wall;
    public wall_move move;
    public GameObject ball;
    public player player;

    private void Start()
    {
        move = wall.GetComponent<wall_move>();
        player = ball.GetComponent<player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            wall.SetActive(true);
            player.speed = 0;
        }
    }
}
