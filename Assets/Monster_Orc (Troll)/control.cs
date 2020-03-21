using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
     Animator ani;
    public GameObject cha;

    // Start is called before the first frame update
    void Start()
    {

         ani = cha.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {



    }

    void attackfunction()
    {
        ani.SetTrigger("attack");
    }
}
