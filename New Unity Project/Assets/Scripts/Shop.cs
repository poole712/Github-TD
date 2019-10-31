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

    public GameObject standardTurret;
    public GameObject laserTurret;

    public bool turretPlacement;

    RaycastHit hit;
    Ray ray;

    private void Start()
    {
        buildManager = BuildManager.instance;
        turretValue = 0;
        standardTurret.SetActive(false);
        laserTurret.SetActive(false);
    }

    public void PurchaseStandardTurret()
    {
        Debug.Log("Standard purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
        turretValue = 1;
        Debug.Log(turretValue);
        standardTurret.SetActive(true);
        laserTurret.SetActive(false);
        turretPlacement = true;
    }

    public void PurchaseSecondTurret()
    {
        Debug.Log("Second purchased");
        buildManager.SetTurretToBuild(buildManager.secondTurretPrefab);
        turretValue = 2;
        standardTurret.SetActive(false);
        laserTurret.SetActive(true);
        turretPlacement = true;
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
        
        if (turretPlacement)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                standardTurret.transform.position = hit.point;
                laserTurret.transform.position = hit.point;
            }
        }
    }
}
