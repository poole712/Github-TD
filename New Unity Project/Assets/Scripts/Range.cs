using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public GameObject rangeCircle;

    // Start is called before the first frame update
    void Start()
    {
        rangeCircle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rangeCircle.SetActive(false);
        }
    }
}
