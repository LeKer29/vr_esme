using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{

    public GameObject prefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
