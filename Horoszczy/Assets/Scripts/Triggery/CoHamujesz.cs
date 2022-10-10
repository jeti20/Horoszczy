using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoHamujesz : MonoBehaviour
{
    public AudioSource hamujesz;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(hamowanie());
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator hamowanie()
    {
        hamujesz.Play();
    }
}
