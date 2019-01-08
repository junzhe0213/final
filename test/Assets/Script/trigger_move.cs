using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_move : MonoBehaviour
{
    public GameObject floormove;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            floormove.SetActive(true);
        }
    }
}
