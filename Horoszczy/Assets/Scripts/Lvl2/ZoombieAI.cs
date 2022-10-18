using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZoombieAI : MonoBehaviour
{
    public GameObject zoombieDestination;
    public GameObject zoombie;
    NavMeshAgent zoomieAgent;
    // Start is called before the first frame update
    void Start()
    {
        zoomieAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        zoomieAgent.SetDestination(zoombieDestination.transform.position);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Bramka"))
        {
            Debug.Log("Collision Bramka - Zoombie");
            zoombie.GetComponent<Animation>().Play("zombie_attack");
        }
    }
}
