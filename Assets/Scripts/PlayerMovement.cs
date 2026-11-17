using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float bounds = 7.77f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
        {
            float xInput = Input.GetAxisRaw("Horizontal");
            float newPositionX = transform.position.x + xInput * speed * Time.deltaTime;

            if(newPositionX < bounds && newPositionX > -bounds)
            {
                transform.position += new Vector3(xInput * speed * Time.deltaTime, 0f, 0f);
            }
        }
}
