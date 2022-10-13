using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroCounter : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            Debug.Log("Collision Nitro-Player");
            collectSound.Play();
            ScroingSystem.theScore += 1;
            Destroy(gameObject);
        }
        
    }
}
