using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public static int turretValue;
    public GameObject turret1;
    public GameObject turret2;

    private void Start()
    {
        buildManager = BuildManager.instance;
        turretValue = 0;
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
        turretValue = 1;
        Debug.Log(turretValue);
    }

    public void PurchaseSecondTurret()
    {
        Debug.Log("Second purchased");
        buildManager.SetTurretToBuild(buildManager.secondTurretPrefab);
        turretValue = 2;
    }

    private void Update()
    {
        if (turretValue == 1)
        {
            turret1.SetActive(true);
            turret2.SetActive(false);
        }

        if (turretValue == 2)
        {
            turret2.SetActive(true);
            turret1.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Currency.currency = Currency.currency + 1000;
        }
    }
}
