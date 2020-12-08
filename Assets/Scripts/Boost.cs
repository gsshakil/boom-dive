using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public PlayerController playerController;
    public float boostTime = 2f;

    private void Awake()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerController.boostMode = true;
            Invoke(nameof(TurnBoostModeOff), boostTime);
        }
    }

    void TurnBoostModeOff()
    {
        playerController.boostMode = false;
        print("Boost Mode Off");
    }
}
