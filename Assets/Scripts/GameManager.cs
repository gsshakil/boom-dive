using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool timeFreeze = false;
    public int score;
    public Text scoreText;
    public bool gameOn = false;
    public GameObject levelCompleteMenu;
    public GameObject gameOverMenu;


    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {
        gameOn = true;
    }

    public void EndGame()
    {
        gameOn = false;
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);

    }

    public void LevelComplete()
    {
        gameOn = false;
        levelCompleteMenu.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ShowMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void HideMenu(GameObject menu)
    {
        menu.SetActive(false);
    }
}
