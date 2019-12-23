using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class begin : MonoBehaviour
{


    // Instantiates a prefab in a circle

    public GameObject prefab;
    public int numberOfObjects = 5;
    public float radius = 20f;

    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            Vector3 pos = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0 ) * radius;
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}