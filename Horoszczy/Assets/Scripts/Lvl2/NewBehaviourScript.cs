using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public bool isKilled;
    public bool InStream = false;
    public float TimeInStream;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Milk"))
        {
            InStream = true;
            Debug.Log("Collision Milk - Zoombie");
            if (TimeInStream >= 2)
            {
                Destroy(gameObject);
                TimeInStream = 0;
                cube.transform.localScale = new Vector3(0.0143741956f, 0.0143741984f, 0.00468107313f);
            }
            
        }
        else
        {
            TimeInStream = 0;
            InStream = false;
        }
    }

    void Update()
    {
        if (InStream)
        {
            TimeInStream += Time.deltaTime;
            Debug.Log(TimeInStream);
        }
    }
}
