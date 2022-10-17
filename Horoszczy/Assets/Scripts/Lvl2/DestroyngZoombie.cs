using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyngZoombie : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Water"))
        {
            Debug.Log("Collision Water - Zoombie");
            Destroy(gameObject);           
        }
    }


}
