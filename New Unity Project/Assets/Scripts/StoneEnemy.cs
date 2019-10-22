using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StoneEnemy : Enemy
{


    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

        speed = Random.Range(1f, 4f);

        agent.speed += speed;
    }

    // Update is called once per frame
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
