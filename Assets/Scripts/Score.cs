using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject stack;
    float scoreVal;
    public Text scoreText;

    private void Start()
    {
        scoreVal = 0;
        scoreText.GetComponent<Text>();
        scoreText.text = scoreVal.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Scored();
        }
    }

    void Scored()
    {
        scoreVal = stack.gameObject.transform.position.y / 5;
        scoreText.text = scoreVal.ToString();
    }
}
