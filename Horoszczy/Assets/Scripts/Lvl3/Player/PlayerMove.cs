using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] float walkSpeed = 15f;

    Vector2 moveInput;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run(); 
    }

    void Run()
    {
        Vector3 playerVelocity = new Vector3(moveInput.x * walkSpeed, myRigidbody.velocity.y, moveInput.y * walkSpeed); //ostatani warotœc moveInput.y * walkspeed to odnosi siê do osi Z, a jest napisane .y ze wzglêdu na to, ¿e new input sytem jest dwuwymiarowy
        myRigidbody.velocity = transform.TransformDirection(playerVelocity);

    }

    //whenever we move this method is goona be called automaticlly
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
