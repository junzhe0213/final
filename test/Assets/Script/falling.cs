using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    float grv = 0.9f;
    Vector3 fall;
    Vector3 sp;
    public GameObject smoke;
    public bool once;

    void Start()
    {
        once = false;
    }

    void FixedUpdate ()
    {
        fall = Vector3.down * 6.8f * Time.deltaTime;
        sp = fall += grv * Vector3.down * Time.deltaTime;
        if(transform.position.y <= 0.13)
        {
            sp = Vector3.zero;
            
            if (once == false)
            {
                gameObject.GetComponent<AudioSource>().Play();
                Instantiate(smoke, transform.position, transform.rotation);
                once = true;
            }
        }
        transform.Translate(sp);
    }

}
