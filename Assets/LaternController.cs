using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaternController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeLight", 0, 0.0001f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeLight()
    {
        bool isOpen = Random.Range(0, 2) == 1 ? true: false ;
        Light light = GetComponent<Light>();
        if (isOpen)
            light.intensity = 10;
        else
            light.intensity = 0;
    }
}
