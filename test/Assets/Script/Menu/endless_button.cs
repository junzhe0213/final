using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void ChangeScene()
    {
        SceneManager.LoadScene("Endless");
    }
}
