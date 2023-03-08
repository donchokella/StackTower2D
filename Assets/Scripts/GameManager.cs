using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverText;

    private void Start()
    {
        gameOver = false;
    }
    private void Update()
    {
        RestartWithRKey();

        if (gameOver && Input.GetMouseButtonDown(0))
        {
            GameOver();
        }

    }
    public void RestartWithRKey()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        gameOverText.SetActive(true);
    }
}
