using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public bool gamezone;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "outside")
        {
            gamezone = true;
        }
       
    }

    private void FixedUpdate()
    {
        if(gamezone == true)
        {
            transform.Translate(0,-1 * Time.deltaTime, - 3 * Time.deltaTime);
        }

        else
        {
            transform.Translate(Vector3.forward * 0 * Time.deltaTime);
        }
    }

}
