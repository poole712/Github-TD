﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoney;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on Screen.");
            return;
        }
        if (Currency.currency >= 25)
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position, Quaternion.Euler(new Vector3(0, -90, 0)));
            Currency.currency = Currency.currency - 25;
        }
    }

    void OnMouseEnter()
    {
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