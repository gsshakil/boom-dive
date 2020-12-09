using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFrezeChangeMaterialProperties : MonoBehaviour
{
    private GameManager gm;
    public Color originalColor;
    public Color newColor;
    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        originalColor = GetComponent<Renderer>().material.color;
        newColor = Color.cyan;
    }

    private void Update()
    {
        if (gm.timeFreeze == true)
        {
            GetComponent<Renderer>().material.color = newColor;

        }
        else
        {
            GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
