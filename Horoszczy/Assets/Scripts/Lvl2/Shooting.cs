using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{//script placed on gun, makes the stream flow on left mouse clikc (holding the button)
    public GameObject milk;
    public GameObject cube;
    void Update()
    {
        if (Input.GetMouseButton(0)) //sprawdza czy naci�niety jest przycisk strza�u i czy liczba naboi ze skryptu Global ammo jest wi�ksza niz 1
        {
            milk.SetActive(true);
            cube.transform.localScale += new Vector3(0, 0, 0.001f);        
        }
        else //if u release the left mous button cube reset it position and the stream is stopped
        {
            milk.SetActive(false);
            cube.transform.localScale = new Vector3(0.0143741956f, 0.0143741984f, 0.00468107313f);
        }
    }

    
}
