using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour
{
    public bool gameover;
    public bool gamestart;

    public Text gameset_text;
    public Text start;
    public Button restart;
    public Button menu;
    public Image score1;
    public Image score2;
    public Image score3;
    public Image clear;

    public GameObject explosion;
    public GameObject ball;

    public player player;

    void Start()
    {
        //抓Player的Script
        ball =GameObject.FindGameObjectWithTag("Player") ;
        player = ball.GetComponent<player>();

        //UI隱藏及設定
        gameover = false;
        gamestart = false;
        gameset_text.text = "";
        start.text = "PRESS ( UP OR SPACE ) TO START";
        restart.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        score1.gameObject.SetActive(false);
        score2.gameObject.SetActive(false);
        score3.gameObject.SetActive(false);
        clear.gameObject.SetActive(false);
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
        if(player != null && player.transform.position.z >= 200)
        {
            Clear();
        }
    }

    void GameSet() // 玩家死掉時呼叫
    {
        gameset_text.text = "GAME OVER";
        restart.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
        if(player.count == 1)
        {
            score1.gameObject.SetActive(true);
        }
        if(player.count == 2)
        {
            score1.gameObject.SetActive(true);
            score2.gameObject.SetActive(true);
        }
        if (player.count == 3)
        {
            score1.gameObject.SetActive(true);
            score2.gameObject.SetActive(true);
            score3.gameObject.SetActive(true);
        }
    }

    void Clear()
    {
        gameset_text.text = "CLEAR!";
        restart.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
        if (player.count == 1)
        {
            score1.gameObject.SetActive(true);
        }
        if (player.count == 2)
        {
            score1.gameObject.SetActive(true);
            score2.gameObject.SetActive(true);
        }
        if (player.count <= 3)
        {
            clear.gameObject.SetActive(true);
            score1.gameObject.SetActive(true);
            score2.gameObject.SetActive(true);
            score3.gameObject.SetActive(true);
        }
    }

    public void ReStart()//重新開始
    {
        SceneManager.LoadScene("Normal");
        player.speed = 4;
    }

    public void Menu()//回到選單
    {
        SceneManager.LoadScene("Menu");
    }
}
