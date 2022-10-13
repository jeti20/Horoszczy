using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyngPlayer : MonoBehaviour
{//Script placed on enemy, makes destroy object with tag "Player" and move to scene Game over
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            Debug.Log("Collision Enemy - Player");
            Destroy(gameObject);
            Destroy(other.gameObject);
            //DŸwiêk, "nie ma mojej posesji" czy coœ 
            SceneManager.LoadScene(2);
        }
    }

   
}
