﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointsGO : MonoBehaviour
{

    public Text pointsTxt;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(pj.points == 1)
        {
            pointsTxt.text = "Hiciste " + pj.points.ToString() + " punto";
        }
        else
        {
            pointsTxt.text = "Hiciste " + pj.points.ToString() + " puntos";
        }
    }
}
