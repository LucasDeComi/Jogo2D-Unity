using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    float pHorizontal;
    float pVertical;
    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if ((horizontal > 0 && horizontal < pHorizontal) || (horizontal < 0 && horizontal > pHorizontal))
            horizontal = 0;
        else
            pHorizontal = horizontal;
        if ((vertical > 0 && vertical < pVertical) || (vertical < 0 && vertical > pVertical))
            vertical = 0;
        else
            pVertical = vertical;
        
        Debug.Log(horizontal + ", " + vertical);

        if (horizontal != 0)
            horizontal = Mathf.Sign(horizontal);
        if (vertical != 0)
            vertical = Mathf.Sign(vertical);

        Vector2 movement = new Vector2(horizontal, vertical);

        transform.Translate(new Vector3(movement.x, movement.y, 0f) * speed * Time.deltaTime, Space.World);
    }
}
