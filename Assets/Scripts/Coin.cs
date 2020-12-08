using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed;
    private GameManager gm;
    private Animator anim;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0), Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.score++;
        //play sound
        //play light vibration
        Vibration.Vibrate(30);
        //play animation/ Instantiate particle effect
        Destroy(gameObject);
    }
}
