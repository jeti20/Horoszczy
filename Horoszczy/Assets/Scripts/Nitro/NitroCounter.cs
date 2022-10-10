using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroCounter : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        collectSound.Play();
        ScroingSystem.theScore += 1;
        Destroy(gameObject);
    }
}
