using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewController : MonoBehaviour
{
    public Transform firstViewPos;
    public Transform thirdViewPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.parent = firstViewPos;
            transform.localPosition = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.parent = thirdViewPos;
            transform.localPosition = Vector3.zero;
        }
    }
}
