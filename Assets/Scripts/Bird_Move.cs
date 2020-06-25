using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird_Move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    public GameObject gameOver;
    public GameObject death;
    public GameObject score;
    public GameController controller;
    public Text gameover_text;
    public int score_1;

    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;
    public GameObject platinum;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        score_1 = controller.GetComponent<GameController>().Score;
    }

    public void Jump()
    {
        rig.velocity = Vector2.up * speed;
        GetComponent<AudioSource>().Play();

    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        gameOver.SetActive(true);
        score.SetActive(false);
        Time.timeScale = 0;
        death.GetComponent<AudioSource>().Play();
        gameover_text.text = controller.scoreText.text;

        if (score_1 >= 10)
        {
            bronze.SetActive(true);
        }
        else if (score_1 >= 50)
        {
            silver.SetActive(true);
        }
        else if (score_1 >= 100)
        {
            gold.SetActive(true);
        }
        else if (score_1 >= 101)
        {
            platinum.SetActive(true);
        }
        
    }
}
