using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_create : MonoBehaviour
{
    public GameObject floor;
    public GameObject cones;
    public Transform[] points;

    void OnTriggerEnter(Collider create)
    {
        if(create.gameObject.tag == "Player")
        {
            Debug.Log("creat");
            Copy();
            Destroy(this.gameObject, 1.5f);
            
        }
    }

	void Copy()
    {
        float random = Random.Range(-2, 3);
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
        Vector3 ran = new Vector3(random, 0.13f, transform.position.z + 10);
        Instantiate(floor, pos, transform.rotation);
        Instantiate(cones, ran, transform.rotation);
        Instantiate(cones, ran, transform.rotation);

    }
}
