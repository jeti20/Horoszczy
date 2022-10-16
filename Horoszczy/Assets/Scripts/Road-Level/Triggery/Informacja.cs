using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informacja : MonoBehaviour
{//Script put on Trigger, and it react with object with tag "Player"
    public GameObject informacja;
    public GameObject player;

    public GameObject informacja1;
    public GameObject informacja2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            informacja.SetActive(true);
            this.gameObject.GetComponent<BoxCollider>().enabled = false; //wy³¹cznie boxcoliera 
            player.GetComponent<PlayerController>().enabled = false; //zatrzymanie postaci
        }
        
    }

    //Next Button
    public void Next()
    {
        informacja1.SetActive(false);
        informacja2.SetActive(true);
    }


    //Cloisng the window, clsong button
    public void Close()
    {
        informacja2.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true; //start postaci
    }
}
