using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool InAreaStart = true;
    private bool InAreaGoal = false;

    [SerializeField]
    private float speed = 7.5f;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "AreaStart")
        {
            InAreaStart = true;
            InAreaGoal = false;

            Debug.Log("Start");
        }
        else if (collision.gameObject.tag == "AreaGoal")
        {
            InAreaGoal = true;
            InAreaStart = false;

            Debug.Log("Goal");
        }
        else
        {
            InAreaStart = false;
            InAreaGoal = false;
        }
    }
}
