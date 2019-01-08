using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_falling : MonoBehaviour
{
    public GameObject cone_l;
    public GameObject cone_r;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            cone_l.SetActive(true);
            cone_r.SetActive(true);
        }
    }
}
