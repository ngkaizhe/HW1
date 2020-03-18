using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayDoorOpenSoundEffect()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        Vector3 cameraPos = Camera.main.transform.position;
        Vector3 dir = Vector3.Normalize(cameraPos - transform.position);
        audioSource.Play();
    }
}
