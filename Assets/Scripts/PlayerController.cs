using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private GameManager gm;
    public float moveSpeed = 5;
    public float idleSpeed = 20f;
    public float boostSpeed = 50;
    public float angularSpeed = 10;

    public bool boostMode = false;

    [SerializeField]
    float bound = 4.5f;
    private Touch touch;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        if(gm.gameOn == true)
        {
            if(boostMode == true)
            {
                moveSpeed = boostSpeed;
            }
            else
            {
                moveSpeed = idleSpeed;
            }
            rb.position = new Vector3(Mathf.Clamp(rb.position.x, -bound, bound), rb.position.y, rb.position.z + moveSpeed * Time.fixedDeltaTime);

            if (Input.touchCount > 0)
            {
                gm.timeFreeze = true;
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    rb.position = new Vector3(rb.position.x + touch.deltaPosition.x * angularSpeed * Time.fixedDeltaTime, rb.position.y, rb.position.z);

                }
            } 
            
            if(touch.phase == TouchPhase.Ended)
            {
                gm.timeFreeze = false;
            }
        }

    }

    public void PlayerRun()
    {
        anim.SetBool("PlayerRun", true);
    }
    public void PlayerDead()
    {
        anim.SetBool("PlayerDead", true);
    }

    public void PlayerDance()
    {
        anim.SetBool("PlayerDance", true);
    }
}
