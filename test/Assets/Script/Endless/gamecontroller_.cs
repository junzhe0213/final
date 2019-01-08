using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroller_ : MonoBehaviour
{
    public bool gamestart;

    public Text gameset_text;
    public Text count_text;
    public Text start;
    public Button restart;
    public Button menu;

    public GameObject explosion;
    public GameObject ball;
    public GameObject cone;

    public player_endless player;
    public cones cones_;

    void Start()
    {
        //抓Player的Script
        ball = GameObject.FindGameObjectWithTag("Player");
        player = ball.GetComponent<player_endless>();

        //UI隱藏及設定
        gameset_text.text = "";
        count_text.text = "";
        start.text = "PRESS ( UP OR SPACE ) TO START";
        restart.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        gamestart = false;
        player.speed = 0;
    }

    void OnCollisionEnter(Collision Other)//碰撞判定
    {

        if (Other.gameObject.tag == "floor2")
        {
            return;
        }

        if (Other.gameObject.tag == "Player")
        {
            Destroy(Other.gameObject);
            Instantiate(explosion, Other.transform.position, Other.transform.rotation);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && gamestart == false || Input.GetKey(KeyCode.Space) && gamestart == false)
        {
            start.text = "";
            player.speed = 4;
            gameObject.GetComponent<AudioSource>().Play();
            gamestart = true;
        }
        if (player == null)
        {
            GameSet();
        }
    }

    void GameSet() // 玩家死掉時呼叫
    {
        gameset_text.text = "You totally get\n\n                        floors";
        count_text.text = ""+ player.count;
        restart.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
    }

    public void ReStart()//重新開始
    {
        SceneManager.LoadScene("Endless");
        player.speed = 4;
    }

    public void Menu()//回到選單
    {
        SceneManager.LoadScene("Menu");
    }
}
