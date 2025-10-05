using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 5f;
    public char axis;
    int direction = 1;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement;
        float moveDirection = direction * 1f;
        
        switch (axis)
        {
            case 'x':
                movement = new Vector2(moveDirection, 0f);
                break;
            case 'y':
                movement = new Vector2(0f, moveDirection);
                break;
            default:
                movement = new Vector2(moveDirection, 0f);
                break;
        }

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrer")
            direction *= -1;
    }
}
