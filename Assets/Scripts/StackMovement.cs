using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackMovement : MonoBehaviour
{
    public float stackSpeed;
    bool isLeft;
    float stackStartPosX = -150f;
    

    private void Start()
    {
        isLeft = false;

        
        transform.position = new Vector2(stackStartPosX, transform.position.y);
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        transform.position = new Vector2(transform.position.x + stackSpeed * Time.fixedDeltaTime, transform.position.y);

        if (transform.position.x > 150)
        {
            isLeft = true;
            stackSpeed *= -1;
        }
        else if (transform.position.x < -150)
        {
            isLeft = false;
            stackSpeed *= -1;

        }
    }
}
