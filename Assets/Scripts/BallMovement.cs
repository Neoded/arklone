using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Vector2 launchForce; 
    Rigidbody2D rb;
    bool isBallLaunched;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Launch") && !isBallLaunched)
        {
            rb.AddForce(launchForce);
            transform.parent = null;
            isBallLaunched = true;
        }
    }
}
