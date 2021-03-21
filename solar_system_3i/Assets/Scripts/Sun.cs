using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public static Sun Instance;
    public float mass = 5;
    private void Start()
    {
        Instance = this;
    }
}
