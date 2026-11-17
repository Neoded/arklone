using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    readonly float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0f, 0f);
    }
}
