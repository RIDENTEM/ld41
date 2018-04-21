﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeManagerScript : MonoBehaviour
{

    //list of planes that the airplane will be traveling across
    [SerializeField] List<GameObject> planes;
    private float planeX;

    private void Awake()
    {
        for (int i = 0; i < planes.Count; i++)
        {
            planeX = planes[i].GetComponent<Transform>().position.x;

            if (i == 0)
                planeX = 0;
            else
                planeX = i * 21;

            planes[i].GetComponent<Transform>().position = new Vector3(planeX, 0, 0);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}