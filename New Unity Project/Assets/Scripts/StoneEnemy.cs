using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class StoneEnemy : Enemy
{
    public Image healthbar;
    float startHealth = 20f;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

        speed = Random.Range(1f, 4f);

        agent.speed += speed;
    }

    void Update()
    {
            if (health == 0f)
            {
                Currency.currency = Currency.currency + reward;
                Debug.Log(Currency.currency);
                Destroy(this.gameObject);
            }

        healthbar.fillAmount = health / startHealth;
    }
}
