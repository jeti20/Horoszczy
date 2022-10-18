using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyngZoombie : MonoBehaviour
{
    public GameObject cube;
    public bool isKilled;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Milk"))
        {
            Debug.Log("Collision Milk - Zoombie");
            Destroy(gameObject, 2f);
            cube.transform.localScale = new Vector3(0.0143741956f, 0.0143741984f, 0.00468107313f);
        }
    }


}
