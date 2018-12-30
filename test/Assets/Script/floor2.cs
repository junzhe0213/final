using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor2 : MonoBehaviour {

    public bool Jump;
    public bool IsGround;

    public GameObject player;

    private AudioSource bounce;

    private void Start()
    {

        //音效
        bounce = this.GetComponent<AudioSource>();
    }

    //接觸判定
    void OnCollisionStay(Collision Other)
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
        //音效音量
        bounce.volume = 0.25f;
        
        //方塊彈跳

        if ( player!=null && player.transform.position.y > 0.6 && Jump == false && IsGround == true)
        {
            Debug.Log("1");
            Jump = true;
            if (Jump == true)
            {
                Debug.Log(".");
                GetComponent<Rigidbody>().AddForce(0, 200, 0);
                bounce.Play();
                IsGround = false;
            }
        }
        
	}
}
