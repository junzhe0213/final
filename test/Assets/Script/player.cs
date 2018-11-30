using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed = 4;

    public bool IsGround;

    //碰撞判定
    void OnCollisionStay (Collision Other)
    {

        if (Other.gameObject.tag == "floor")
        {
            IsGround = true;
        }
        if (Other.gameObject.tag == "floor2")
        {
            IsGround = true;
        }
    }
	
	void FixedUpdate ()
    {
        //移動
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) && IsGround)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 150);
            
            if (transform.position.y > 0.5)
            {
                IsGround = false;
            }
        }
    }
}
