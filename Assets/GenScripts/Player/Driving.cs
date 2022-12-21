using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour
{
    Rigidbody2D rb2D;

    float speed;
    float brakeForce;
    float maxSpeed;
    float turnSpeed;
    float currentAngle;
    Quaternion currentRotation;

    [SerializeField] GameObject carBody;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        speed = 1.0f;
        maxSpeed = 80f;
        brakeForce = 3f;
        turnSpeed = 1f;
        currentAngle = 0f;
        currentRotation = carBody.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = carBody.transform.rotation;
        ChangeDirectionAndSpeed();
        Debug.Log(speed);
        MoveCar();
    }

    void ChangeDirectionAndSpeed()
    {
        // Input.GetKey remains true while held down
        // Accerlating function
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (speed < maxSpeed)
            {
                speed += 1;
            }
            if (speed >= maxSpeed)
            {
                Debug.Log("Max Speed is reached. Current Speed: " + speed);
                return;
            }
        }
        // Braking function
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (speed > 0)
            {
                speed -= brakeForce;
            }
            if (speed < 0)
            {
                speed = 0;
            }
        }
        // Next couple turn the car
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentAngle = turnSpeed * Time.deltaTime;
            carBody.transform.rotation *= Quaternion.AngleAxis(currentAngle, Vector2.up);
        }
    }

    void MoveCar()
    {
        transform.position = new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
    }
}
