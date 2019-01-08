using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_move : MonoBehaviour
{
    public float speed = 10;
    public GameObject ball;
    public player player;

    private void Start()
    {
        player = ball.GetComponent<player>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.speed = 25;
            gameObject.GetComponent<AudioSource>().Play();
        }
        Destroy(gameObject,0.5f);
    }
}
