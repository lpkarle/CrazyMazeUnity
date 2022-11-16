using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool inAreaStart = true;
    private bool inAreaGoal = false;

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
            Debug.Log("Start");

            inAreaStart = true;
            inAreaGoal = false;
        }
        else if (collision.gameObject.tag == "AreaGoal")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            inAreaGoal = true;
            inAreaStart = false;

        }
        else
        {
            inAreaStart = false;
            inAreaGoal = false;
        }
    }

    public bool getInAreaStart()
    {
        return inAreaStart;
    }

    public bool getInAreaGoal()
    {
        return inAreaGoal;
    }
}
