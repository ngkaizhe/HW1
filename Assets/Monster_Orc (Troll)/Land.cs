using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{

    AudioSource land;

    // Start is called before the first frame update
    void Start()
    {

        land = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void play1()
    {
        land.Play();
    }
}
