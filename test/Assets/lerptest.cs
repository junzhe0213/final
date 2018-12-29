using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerptest : MonoBehaviour
{
    public float targetValue;
    public float baseBias;
    public float speed = 1;
    public bool lightUp = false;
    private float viewValue = 0.5f;
    private Renderer rend;
    private Color baseColor;

	// Use this for initialization
	//void Start () {
        //rend = GetComponent<Renderer>();
        //baseColor = rend.material.GetColor("_EmissionColor");
	//}
	
	// Update is called once per frame
	void Update () {
        //if (lightUp)
        {
            //viewValue = Mathf.Lerp(viewValue, targetValue, Time.deltaTime * speed);
            //Color currentColor = baseColor * Mathf.LinearToGammaSpace(viewValue);
            //rend.material.SetColor("_EmissionColor", currentColor);
        }
        //else
        {
            //viewValue = Mathf.Lerp(viewValue, baseBias, Time.deltaTime * speed);
            //Color currentColor = baseColor * Mathf.LinearToGammaSpace(viewValue);
            //rend.material.SetColor("_EmissionColor", currentColor);
        }
        
	}
}
