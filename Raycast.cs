using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public bool collision;
    private float positionX;
    private float positionY;
    public float gravity;
    public float vX;
    public float vY;

    public void FixedUpdate()
    {
        collision = Physics2D.Raycast(transform.position, Vector2.down, 0.07f);
    }
    void Update()
    {
        ParabolicMovement();    
    }

    void ParabolicMovement()
    {
        if (!collision)
        {
            positionX += vX * Time.deltaTime;
            vY += -gravity * Time.deltaTime;
            positionY += vY * Time.deltaTime;
            transform.Translate(positionX, positionY, 0);

        }
    }
}
