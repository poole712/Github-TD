using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public static int currency;
    public Text curr;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("currencyTick");
        curr.text = "Currency: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        curr.text = "Currency: " + currency;
    }

    IEnumerator currencyTick()
    {
        currency++;
        yield return new WaitForSeconds(1);

        StartCoroutine("currencyTick");
    }
}
