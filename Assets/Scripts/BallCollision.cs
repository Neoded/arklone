using UnityEngine;

public class BallCollision : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            gameManager.DecreaseBlocks();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        gameManager.RestartScene();
    }
}
