using UnityEngine;

public class Movement : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 180f;

    public float sensitivity = 1f;
 
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}