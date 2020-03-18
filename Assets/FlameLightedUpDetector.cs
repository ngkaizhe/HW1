using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameLightedUpDetector : MonoBehaviour
{
    public GameObject redFlame;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            // Debug.Log("Player stay in the box collider!");
            if (GameInput.GetKeyDown(KeyCode.E))
            {
                // Debug.Log("Player stay in and pressed E");
                redFlame.GetComponent<Animator>().SetBool("FlameStart", true);
            }
        }
    }
}
