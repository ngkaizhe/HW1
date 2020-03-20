using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampShowerController : MonoBehaviour
{
    public int currentFlameLightUp;
    public int totalFlameLightUp;

    // Start is called before the first frame update
    void Start()
    {
        currentFlameLightUp = 0;
        Text myText = GetComponent<Text>();
        myText.text = string.Format("{0} / {1}", currentFlameLightUp, totalFlameLightUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFlameLightUp()
    {
        currentFlameLightUp++;
        Text myText = GetComponent<Text>();
        myText.text = string.Format("{0} / {1}", currentFlameLightUp, totalFlameLightUp);
    }
}
