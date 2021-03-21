using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private Sun sun;
    
    void Start()
    {
        sun = Sun.Instance;         
    }

}
