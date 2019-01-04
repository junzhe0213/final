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
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void ReBack()
    {
        fadeout.SetBool("press", false);
        GetComponent<CanvasGroup>().interactable = true;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
