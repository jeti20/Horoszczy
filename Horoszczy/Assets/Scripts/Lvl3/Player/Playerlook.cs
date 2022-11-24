using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerlook : MonoBehaviour
{

    [SerializeField] float minViewDistance = 25f; //limit the range of view of player
    [SerializeField] Transform playerBody; //cia�o b�dzie obraca�o si� razem z kamer�

    public float mouseSensitivity = 100f;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, minViewDistance); //tworzymy zasi�g kamery kt�ra b�dzie obraca�� si� tylko w zakresie -90x i min viewdisance

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //obracamy tylko prawo lewo (x)
        playerBody.Rotate(Vector3.up * mouseX); //player rotate with the camera

    }
}
