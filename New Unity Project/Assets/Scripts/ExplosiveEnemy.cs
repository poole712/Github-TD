using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ExplosiveEnemy : Enemy
{
    public Image healthbar;
    float startHealth = 5f;
    public GameObject explosiveEffect;
    public Transform cameraTransform;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;

        speed = Random.Range(50f, 50f);

        agent.speed += speed;
    }
    
    void Update()
    {     
            if (health <= 0f)
            {
                Currency.currency = Currency.currency + reward;
                Debug.Log(Currency.currency);
                Explode();
                Destroy(this.gameObject);
            }

        healthbar.fillAmount = health / startHealth;
        healthbar.transform.LookAt(cameraTransform);
    }

    void Explode()
    {
        GameObject effectIns = (GameObject)Instantiate(explosiveEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
    }

}
