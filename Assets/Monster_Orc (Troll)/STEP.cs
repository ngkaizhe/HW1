using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STEP : MonoBehaviour
{

    AudioSource step;

    // Start is called before the first frame update
    void Start()
    {

        step = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void play()
    {
        step.Play();
    }

    void stop()
    {
        step.Stop();
    }
}
