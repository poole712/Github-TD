using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoney;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on Screen.");
            return;
        }
        if (Currency.currency >= 25 && Shop.turretValue == 1)
        {
            GameObject turretToBuild = buildManager.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position, Quaternion.Euler(new Vector3(0, -90, 0)));
            Currency.currency = Currency.currency - 25;
        }

        if (Currency.currency >= 100 && Shop.turretValue == 2)
        {
            GameObject turretToBuild = buildManager.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position, Quaternion.Euler(new Vector3(0, -90, 0)));
            Currency.currency = Currency.currency - 100;
        }
    }

    void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (Currency.currency >= 25)
        {
            rend.material.color = hoverColor;
        }

        else
        {
            rend.material.color = notEnoughMoney;
        }

        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
