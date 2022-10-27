using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        transform.position = new Vector3(0, 9.8f, -9.309998f) + player.transform.position;
    }
}
