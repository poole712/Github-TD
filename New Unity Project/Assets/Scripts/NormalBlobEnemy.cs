using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormalBlobEnemy : MonoBehaviour
{
    public Transform homeBase;

    //public static float Health = 5f;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = homeBase.position;
        hp = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
        {
            Currency.currency++;
            Debug.Log(Currency.currency);
            Destroy(this.gameObject);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        hp--;
    }

    
}
