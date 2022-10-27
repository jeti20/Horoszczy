using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapSpawner : MonoBehaviour
{//spawn soap
    public GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
    }
}
