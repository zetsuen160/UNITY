﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    
   Rigidbody rb;
   public int N = 2;
   Vector3 r;
   public Vector3 V;
   GameObject[] GO = new GameObject[4];
   float g = 6.67408e-2F;
   public float m, M;

   void Start()
   {
       rb = GetComponent<Rigidbody>();

   }

   void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int k = 0; i != k && k < 4; k++)
            {
                r = GO[i].transform.position - GO[k].transform.position;
                float l = -g * m / Mathf.Pow(r.magnitude, 3);
                rb.AddForce(l * r);

                Debug.Log(r);
            }
        }
    }

  
}
