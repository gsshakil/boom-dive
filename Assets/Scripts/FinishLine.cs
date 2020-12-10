using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gm;
    public GameObject winParticle;
    private PlayerController player;


    private void Awake()
    {
        player = GameObject.FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Vibration.Vibrate(500);
            player.PlayerDance();
            winParticle.SetActive(true);
            winParticle.GetComponent<ParticleSystem>().Play();
            Invoke("ReachedFinishLine", 1f);
            print("Level Complete");
        }
    }

    void ReachedFinishLine()
    {
        gm.LevelComplete();
    }
}
