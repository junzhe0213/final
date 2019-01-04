using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class back_button : MonoBehaviour
{
    public Animator back;

    private void Start()
    {
        back = GetComponent<Animator>();
    }

    public void Back()
    {
        back.SetBool("press", true);
    }

    public void start()
    {
        back.SetBool("press", false);
    }
}
