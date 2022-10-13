using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroSpawner : MonoBehaviour
{

    public GameObject Nitro;
    public int zPos = 0;
    public bool creatingSection = false;
    public float boundries = 8.7f;
    //random X i dodawanie Z
    // Start is called before the first frame update  

    // Update is called once per frame
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

        Instantiate(Nitro, new Vector3(Random.Range(-boundries, boundries), 2.5f, Random.Range(0, zPos)), Quaternion.Euler(0, 90, 0));
        
        yield return new WaitForSeconds(1);
        zPos += 200;
        creatingSection = false;
    }
}
