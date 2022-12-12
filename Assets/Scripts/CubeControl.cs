using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // The speed at which the object should rotate, in degrees per second.
    public float rotationSpeed = 75.0f;

    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float rotationAmount = rotationSpeed * Time.deltaTime;

        if (horizontalInput < 0)
        {
            transform.Rotate(Vector3.down, rotationAmount);
        }
        else if (horizontalInput > 0)
        {
            transform.Rotate(Vector3.up, rotationAmount);
        }

        if (verticalInput < 0)
        {
            transform.Rotate(Vector3.left, rotationAmount);
        }
        else if (verticalInput > 0)
        {
            transform.Rotate(Vector3.right, rotationAmount);
        }
    }
    
}