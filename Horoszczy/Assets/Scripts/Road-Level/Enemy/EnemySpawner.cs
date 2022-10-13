using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemyBlock;
    private int zPos = 0;
    public bool creatingSection = false;
    private float borders = 8.7f;
 
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

        Instantiate(enemy, new Vector3(Random.Range(-borders, borders), 4f, Random.Range(0, zPos)), Quaternion.Euler(0, 0, 180));
        Instantiate(enemyBlock, new Vector3(0, 4f, Random.Range(0, zPos)), Quaternion.Euler(0, 0, 180));

        yield return new WaitForSeconds(1);
        zPos += 200;
        creatingSection = false;
    }
}
