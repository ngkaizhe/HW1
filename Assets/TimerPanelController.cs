using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerPanelController : MonoBehaviour
{
    public static TimerPanelController instance;
    public Text Timer;

    private float CurrentTimer;
    private bool isTimerStopped;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        CurrentTimer = 0;
        isTimerStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTimerStopped)
        {
            CurrentTimer += Time.deltaTime;
            Timer.text = string.Format("{0}:{1}s", (int)CurrentTimer, (int)((CurrentTimer % 1) * 100));
        }
    }

    public void stopTimer()
    {
        isTimerStopped = true;
    }

    public void playTimer()
    {
        isTimerStopped = false;
    }
}
