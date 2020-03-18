using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    
    public static bool GetKeyDown(KeyCode code)
    {
        if(false) // Game wasnt start yet
        {
            return false;
        }
        else if(Input.GetKeyDown(code))
        {
            Debug.Log("GameInput get key down called!");
            return true;
        }
        else
        {
            return false;
        }
    }

}
