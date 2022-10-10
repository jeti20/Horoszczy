using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;
    public int zPos = 0;
    public bool creatingSection = false;
    public float Wide1 = 579;
    public float Wide2 = 562;
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

        Instantiate(Enemy, new Vector3(Random.Range(Wide1, Wide2), 307.5273f, Random.Range(0, zPos)), Quaternion.Euler(180, 0, 0));
        
        yield return new WaitForSeconds(1);
        zPos += 200;
        creatingSection = false;
    }
}
