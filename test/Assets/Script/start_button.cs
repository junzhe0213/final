using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class start_button : MonoBehaviour
{
    public GameObject endless;

    private Vector3 smooth;
    private Vector3 speed;
    private bool isDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }

    void FixedUpdate()
    {
        if (isDown)
        {
            Debug.Log("..");
            smooth = 0.2f * Vector3.right * Time.deltaTime;
            speed = 8 * Vector3.right * Time.deltaTime;
            smooth += speed;
        }
    }
}
