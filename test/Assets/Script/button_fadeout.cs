using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_fadeout : MonoBehaviour
{
    public Animator fadeout;

    private void Start()
    {
        fadeout = GetComponent<Animator>();
    }

    public void Press()
    {
        fadeout.SetBool("press",true);
        Destroy(gameObject, 1);
	}

}
