using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;

    private GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(gm.timeFreeze == false)
        {
            transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
        } else
        {
            transform.RotateAround(target.transform.position, Vector3.up, (speed/10) * Time.deltaTime);
        }

    }
}
