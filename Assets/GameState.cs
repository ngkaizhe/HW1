using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public enum State
    {
        Play,
        Pause,
        Animation,
        End,
    };

    private State _currentState;
    public FlameLightedUpDetector[] flameLightUpList;

    private void Start()
    {
        _currentState = State.Play;
    }

    // Update is called once per frame
    void Update()
    {
        bool allLightUp = true;
        for(int i=0; i<flameLightUpList.Length; i++)
        {
            if(flameLightUpList[i].flameLightUp == false)
            {
                allLightUp = false;
                break;
            }  
        }

        // open door effect
        if (allLightUp)
        {

        }
    }

    public State currentState
    {
        get { return _currentState; }
        set
        {
            // if State is play
            if(value == State.Play)
            {
                GameInput.freezeInput = false;
                Time.timeScale = 1;
            }
            // if State is pause, freeze the input and pause the game(timeScale == 0)
            else if (value == State.Pause)
            {
                GameInput.freezeInput = true;
                Time.timeScale = 0;
            }
            // if State is animation time, freeze the input only
            else if(value == State.Animation || value == State.End)
            {
                GameInput.freezeInput = true;
                Time.timeScale = 1;
            }
            // if State is end, freeze the input and call end game animation
            else if (value == State.End)
            {
                GameInput.freezeInput = true;
                Time.timeScale = 1;

                // call the end game animation
            }

            _currentState = value;
        }
    }
}
