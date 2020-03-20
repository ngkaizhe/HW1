using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverSceneStartUp : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = string.Format("Congragulation! You Used {0}s To finish!", ApplicationModel.totalUsedTime);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
