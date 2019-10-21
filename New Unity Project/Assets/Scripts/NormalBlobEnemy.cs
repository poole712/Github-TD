using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormalBlobEnemy : MonoBehaviour
{
    public Transform homeBase;

    public float Health;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
