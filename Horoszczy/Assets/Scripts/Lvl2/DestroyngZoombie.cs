using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyngZoombie : MonoBehaviour
{//script destroyng zoombie after 2secods after ontiggerener with Stream
    public GameObject cube;
 
    public bool InStream = false;
    public  float TimeInStream = 0;

     public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Milk"))
        {
            InStream = true;
            TimeInStream += Time.deltaTime;
            Debug.Log("Collision Milk - Zoombie");          
                    
        }
        else
        {
            InStream = false;
            Debug.Log(InStream);
            Debug.Log("ZERO STAY");
            TimeInStream = 0f;
        }

        if (TimeInStream >= 2)
        {
            Destroy(gameObject);
            TimeInStream = 0f;
            cube.transform.localScale = new Vector3(0.0143741956f, 0.0143741984f, 0.00468107313f);

        }
        Debug.Log(TimeInStream);
    }

    public void OnTriggerExit(Collider other)
    {
        TimeInStream = 0f;
        Debug.Log("ZERO EXIT");
        Debug.Log(TimeInStream);
    }
   
}
