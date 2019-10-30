using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float hp = 50;
    public GameObject explosvieEnemy;

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
        Destroy(other.gameObject);

        if (explosvieEnemy.name == "Explosive Blob")
        {
            hp = hp - 3;
        }
    }
}
