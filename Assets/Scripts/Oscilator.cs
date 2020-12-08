using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilator : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;

    private void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
