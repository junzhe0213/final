using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spark : MonoBehaviour
{
	void Update ()
    {
        Destroy(this.gameObject, 1f);
    }
}
