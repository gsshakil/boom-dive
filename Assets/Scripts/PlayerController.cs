using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public GameManager gm;
    public float moveSpeed = 5;
    public float angularSpeed = 10;

    [SerializeField]
    float bound = 4.5f;
    private Touch touch;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        if(gm.gameOn == true)
        {
            rb.position = new Vector3(Mathf.Clamp(rb.position.x, -bound, bound), rb.position.y, rb.position.z + moveSpeed * Time.fixedDeltaTime);

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    rb.position = new Vector3(rb.position.x + touch.deltaPosition.x * angularSpeed, rb.position.y, rb.position.z);

                }
            }
        }

    }
}
