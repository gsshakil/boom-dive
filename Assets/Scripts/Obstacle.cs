using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gm.EndGame();
            //vibrate
            Vibration.Vibrate(500);
            //camera shake
            print("Camera Shaking");
            //shome game over menu after 1s
            Invoke("GameOver", 0.5f);
        }
    }

    void GameOver()
    {
        gm.GameOver();
    }
}
