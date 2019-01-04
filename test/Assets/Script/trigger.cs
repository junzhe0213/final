using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {
    public Skybox sky;

    private void Start()
    {
        sky = GetComponent<Skybox>();
        sky.material.color = new Color32(81, 156, 244, 255);
    }

    private void OnTriggerEnter(Collider other)
    {
        sky.material.color = new Color32(81, 156, 244, 255);
        if (other.gameObject.tag == "Player")
        {
            sky.material.color = new Color32(166, 9, 234, 255);
        }
    }


    void Update () {
		
	}
}
