using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject milk;
    public GameObject cube;
    void Update()
    {
        if (Input.GetMouseButton(0)) //sprawdza czy naciœniety jest przycisk strza³u i czy liczba naboi ze skryptu Global ammo jest wiêksza niz 1
        {
            milk.SetActive(true);
            cube.transform.localScale += new Vector3(0, 0, 0.001f);        
        }

        else
        {
            milk.SetActive(false);
            cube.transform.localScale = new Vector3(0.0143741956f, 0.0143741984f, 0.00468107313f);
        }
    }

    
}
