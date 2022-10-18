using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoombieSpawner : MonoBehaviour
{

    public GameObject zombie;
    public bool creatingSection = false;
    private float borders = 7f;
 
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateNitro()); // w corutine musi byc opóŸneinie nie mozna tego zrobiæ w metodzie, opóznienie pojawiania sie mapy
        }
    }
    IEnumerator GenerateNitro()
    {

        Instantiate(zombie, new Vector3(Random.Range(-50, 50), 0, Random.Range(-borders, borders)), Quaternion.Euler(0, 0, 180));
        yield return new WaitForSeconds(3);
        creatingSection = false;
    }
}
