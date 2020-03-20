using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static bool freezeInput;

    private void Start()
    {
        freezeInput = false;
    }

    public static bool GetKeyDown(KeyCode code)
    {
        // pause key is the special key
        if (code == KeyCode.P && Input.GetKeyDown(code))
        {
            return true;
        }
        else if(freezeInput) // Game wasnt start yet
        {
            return false;
        }
        else if(Input.GetKeyDown(code))
        {
            // Debug.Log("GameInput get key down called!");
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool GetKeyUp(KeyCode code)
    {
        // pause key is the special key
        if (code == KeyCode.P && Input.GetKeyUp(code))
        {
            return true;
        }
        else if(freezeInput) // Game wasnt start yet
        {
            return false;
        }
        else if(Input.GetKeyUp(code))
        {
            // Debug.Log("GameInput get key down called!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool GetButtonDown(string code)
    {
        if (freezeInput) // Game wasnt start yet
        {
            return false;
        }
        else if (Input.GetButtonDown(code))
        {
            // Debug.Log("GameInput get key down called!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public static float GetAxis(string code)
    {
        if (freezeInput) // Game wasnt start yet
        {
            return 0;
        }
        else
        {
            return Input.GetAxis(code);
        }
    }

}
