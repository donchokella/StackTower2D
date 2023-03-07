using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject stack;
    float scoreVal;
    public Text scoreText;
    Text score_text;

    private void Start()
    {
        scoreVal = 0;
        score_text = scoreText.GetComponent<Text>();
        scoreText.text = scoreVal.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameManager.gameOver)
        {
            Scored();
        }
        if (GameManager.gameOver)
        {
            GameOverScore();
        }
    }

    void Scored()
    {
        scoreVal = stack.gameObject.transform.position.y / 5;
        scoreText.text = scoreVal.ToString();
    }

    void GameOverScore()
    {
        score_text.transform.position = new Vector3(540, 960, 0);
        score_text.fontSize = 150;
    }
}
