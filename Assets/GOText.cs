using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOText : MonoBehaviour
{
    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "gameoverballTag")
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        

        if(other.gameObject.tag == "blackheartTag")
        {
            Debug.Log(this.score += 10);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "whiteheartTag")
        {
            Debug.Log(this.score += 30);
        }
    }
}
