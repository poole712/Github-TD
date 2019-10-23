using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StoneEnemy : Enemy
{
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

        speed = Random.Range(1f, 4f);

        agent.speed += speed;
    }

    void Update()
    {
            if (health == 0)
            {
                Currency.currency = Currency.currency + reward;
                Debug.Log(Currency.currency);
                Destroy(this.gameObject);
            }
    }
}
