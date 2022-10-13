using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informacja : MonoBehaviour
{//Script put on Trigger, and it react with object with tag "Player"
    public GameObject informacja;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            StartCoroutine(Info());
            player.GetComponent<PlayerController>().enabled = false; //zatrzymanie postaci
        }
        
    }

    IEnumerator Info()
    {
        informacja.SetActive(true);
        yield return new WaitForSeconds(5); //mo¿na dodaæ button ¿e jest ready
        informacja.SetActive(false);
        this.gameObject.GetComponent<BoxCollider>().enabled = false; //wy³¹cznie boxcoliera
        player.GetComponent<PlayerController>().enabled = true; //start postaci
    }
}
