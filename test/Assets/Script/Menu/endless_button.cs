using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless_button : MonoBehaviour
{
    public Animator endless;

    private void Start()
    {
        endless = GetComponent<Animator>();
    }

    public void Back()
    {
        endless.SetBool("back", true);
    }

    public void start()
    {
        endless.SetBool("back", false);
    }
}
