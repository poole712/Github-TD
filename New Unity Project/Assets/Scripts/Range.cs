using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public GameObject rangeCircle;
    public float range;

    void Start()
    {
        rangeCircle.transform.localScale = new Vector3(range, 0.1f, range);
    }
    
}
