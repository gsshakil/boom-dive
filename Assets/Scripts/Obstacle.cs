using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gm;
    private PlayerController player;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        player = GameObject.FindObjectOfType<PlayerController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gm.EndGame();
            Vibration.Vibrate(500);
            //camera shake
            print("Camera Shaking");
            Invoke("GameOver", 0.5f);
        }
    }

    void GameOver()
    {
        gm.GameOver();
    }
}
