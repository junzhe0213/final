using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
    public Skybox sky;

    private void Start()
    {
        sky = GetComponent<Skybox>();
        sky.material.color = new Color32(129, 157, 248, 255);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sky.material.color = new Color32(255, 163, 241, 255);
        }
    }


    void Update () {
		
	}
}
