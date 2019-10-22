using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int reward;

    public float speed;

    public Transform homeBase;


    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

    }

    

    private void OnTriggerEnter(Collider other)
    {
        health--;
    }
}
