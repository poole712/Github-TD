using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public static int turretValue;

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
    }

    public void PurchaseSecondTurret()
    {
        Debug.Log("Second purchased");
        buildManager.SetTurretToBuild(buildManager.secondTurretPrefab);
        turretValue = 2;
    }
}
