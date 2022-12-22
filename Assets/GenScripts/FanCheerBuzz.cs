using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCheerBuzz : MonoBehaviour
{
    // Just move the fan around to make it look like it is cheering or "buzzing"

    // Assign the gameobject in script
    GameObject fan;

    int currentDirection;
    Vector2 startingPosition;
    Vector2 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        fan = gameObject;
        currentDirection = 0;
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDirection > 3)
        {
            currentDirection = 0;
        }
        Buzz();
    }

    void Buzz()
    {
        if (currentDirection == 0)
        {
            // Just put f to make a decimel work
            newPosition = new Vector2(startingPosition.x + 0.05f, startingPosition.y);
            transform.position = Vector2.MoveTowards(newPosition, newPosition, 1);
        }
        if (currentDirection == 1)
        {
            // Just put f to make a decimel work
            newPosition = new Vector2(startingPosition.x - 0.05f, startingPosition.y);
            transform.position = Vector2.MoveTowards(newPosition, newPosition, 1);
        }
        if (currentDirection == 2)
        {
            // Just put f to make a decimel work
            newPosition = new Vector2(startingPosition.x, startingPosition.y + .05f);
            transform.position = Vector2.MoveTowards(newPosition, newPosition, 1);
        }
        if (currentDirection == 3)
        {
            // Just put f to make a decimel work
            newPosition = new Vector2(startingPosition.x, startingPosition.y -.05f);
            transform.position = Vector2.MoveTowards(newPosition, newPosition, 1);
        }
        currentDirection += 1;
    }
}
