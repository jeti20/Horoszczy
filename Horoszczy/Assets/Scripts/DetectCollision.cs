using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{//Script placed on enemy, react with object with tag "Myd³o"
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Myd³o"))
        {
            Debug.Log("Collision Enemy - mydlo");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }   
    }
}
