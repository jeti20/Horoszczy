using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 30;
    private float turnSpeed = 10;
    private float boundries = 8.4f;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (transform.position.x < -boundries)
        {
            transform.position = new Vector3(-boundries, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundries)
        {
            transform.position = new Vector3(boundries, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * turnSpeed * Time.deltaTime);

        if (Input.GetKey("left shift"))
        {
            speed = 100;
        }
        else
        {
            speed = 30;
        }

        
    }
}
