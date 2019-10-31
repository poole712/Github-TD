using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float hp = 50;
    public GameObject explosvieEnemy;
    public GameObject explosiveEffect;

    private void Update()
    {
        if (hp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        hp--;
        Explode();
        Destroy(other.gameObject);

        if (explosvieEnemy.name == "Explosive Blob")
        {
            hp = hp - 4;
        }
    }

    void Explode()
    {
        GameObject effectIns = (GameObject)Instantiate(explosiveEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
    }
}
