using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NormalEnemy : Enemy
{
    public Image healthbar;
    float startHealth = 5f;
    public Transform cameraTransform;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

        speed = Random.Range(2f, 6f);

        agent.speed += speed;
    }
    
    void Update()
    {     
            if (health <= 0f)
            {
                Currency.currency = Currency.currency + reward;
                Debug.Log(Currency.currency);
                Destroy(this.gameObject);
            }

        healthbar.fillAmount = health / startHealth;

        healthbar.transform.LookAt(cameraTransform);
    }

}
