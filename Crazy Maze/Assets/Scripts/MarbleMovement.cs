using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration * speed;

        rb.AddForce(tilt);

        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.green);
    }
}
