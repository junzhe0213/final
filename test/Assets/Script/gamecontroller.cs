using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour
{
    public bool gameover;

    public Text gameset_text;
    public Button restart;
    public Button menu;

    public GameObject explosion;
    public GameObject ball;

    public player player_speed;

    void Start()
    {
        //抓Player的Script
        ball =GameObject.FindGameObjectWithTag("Player") ;
        player_speed = ball.GetComponent<player>();

        //UI隱藏及設定
        gameover = false;
        gameset_text.text = "";
        restart.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision Other)//碰撞判定
    {

        if (Other.gameObject.tag == "floor2")
        {
            return;
        }

        if (Other.gameObject.tag == "Player")
        {
            Instantiate(explosion, Other.transform.position, Other.transform.rotation);
            Destroy(Other.gameObject);
            GameSet();
        }
    }

    void GameSet() // 玩家死掉時呼叫
    {
        gameset_text.text = "GAME OVER";
        restart.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);


    }

    public void ReStart()//重新開始
    {
        SceneManager.LoadScene("Normal");
        player_speed.speed = 4;
    }

    public void Menu()//回到選單
    {
        SceneManager.LoadScene("Menu");
    }
}
