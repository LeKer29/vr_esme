using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public static Sun Instance;
    private void Start()
    {
        Instance = this;
    }

    private void FixedUpdate()
    {
        Instance.transform.position = Vector3.zero;
    }
}
