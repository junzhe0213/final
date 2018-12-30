using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_destory : MonoBehaviour
{
    
    public GameObject explosion;

    void OnCollisionStay(Collision Other)
    {

        //跳台碰撞判定
        if(Other.gameObject.tag == "floor2")
        {
            return;
        }

        //角色碰撞判定
        if(Other.gameObject.tag == "Player")
        {
            Instantiate(explosion, Other.transform.position, Other.transform.rotation);
        }

        //刪除角色
        Other.gameObject.SetActive(false);

    }

}
