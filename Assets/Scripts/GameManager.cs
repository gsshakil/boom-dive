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

    private PlayerController player;


    private void Awake()
    {
        player = GameObject.FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {
        gameOn = true;
        player.PlayerRun();
    }

    public void EndGame()
    {
        gameOn = false;
        player.PlayerDead();
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);

    }

    public void LevelComplete()
    {
        gameOn = false;
        player.PlayerDance();
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
