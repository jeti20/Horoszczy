using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 70;
    private float turnSpeed = 10;
    private float xRangeRight = 579f;
    private float xRangeLeft = 562f;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (transform.position.x < xRangeLeft)
        {
            transform.position = new Vector3(xRangeLeft, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRangeRight)
        {
            transform.position = new Vector3(xRangeRight, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * turnSpeed * Time.deltaTime); 
    }
}
