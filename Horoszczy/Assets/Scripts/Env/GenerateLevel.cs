using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateLevel : MonoBehaviour
{
    public GameObject road;
    public GameObject enemy;

    public int zPos = 200;
    public bool creatingSection = false;
   
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection()); // w corutine musi byc opóŸneinie nie mozna tego zrobiæ w metodzie, opóznienie pojawiania sie mapy
        } 
    }

    IEnumerator GenerateSection()
    {
        
        Instantiate(road, new Vector3(0, 0, zPos), Quaternion.Euler(0, 0, 0));
        Instantiate(enemy, new Vector3(0, 0, zPos), Quaternion.Euler(0, 0, 0));
        zPos +=200;
        yield return new WaitForSeconds(1);
        creatingSection = false;

        

    }
}
