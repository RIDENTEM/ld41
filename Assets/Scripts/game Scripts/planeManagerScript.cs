using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeManagerScript : MonoBehaviour
{

    //list of planes that the airplane will be traveling across
    [SerializeField] List<GameObject> planes;
    private float planeX;
    [SerializeField] private float planeY;
    private void Awake()
    {
        for (int i = 0; i < planes.Count; i++)
        {
            planeX = planes[i].GetComponent<Transform>().position.x;

            if (i == 0)
                planeX = 0;
            else
                planeX = i * 22;

            planes[i].GetComponent<Transform>().position = new Vector3(planeX, planeY, 0.0f);
        }
    }

   
}
