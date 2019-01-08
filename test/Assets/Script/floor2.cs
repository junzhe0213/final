using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor2 : MonoBehaviour
{

    public bool Jump;
    public bool IsGround;

    public GameObject player;

    void OnCollisionStay(Collision Other) //接觸判定
    {
        if (Other.gameObject.tag == "Player")
        {
            Jump = false;
        }
        if (Other.gameObject.tag == "Player")
        {
            IsGround = true;
        }
    }
	
	void Update ()
    {       
        if ( player!=null && player.transform.position.y > 0.6 && Jump == false && IsGround == true) //方塊彈跳
        {
            Jump = true;
            if (Jump == true)
            {
                GetComponent<Rigidbody>().AddForce(0, 200, 0);
                IsGround = false;
            }
        }
        
	}
}
