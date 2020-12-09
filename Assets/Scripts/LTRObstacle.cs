using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTRObstacle : MonoBehaviour
{
    private GameManager gm;
    private Animator anim;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(gm.timeFreeze == true)
        {
            anim.speed = 0;
        } else
        {
            anim.speed = 1;
        }
    }
}
