using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOn = false;
    public GameObject levelCompleteMenu;


    public void StartGame()
    {
        gameOn = true;
    }

    public void EndGame()
    {
        gameOn = false;
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
