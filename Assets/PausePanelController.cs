using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanelController : MonoBehaviour
{
    public GameObject PauseBG;
    // Start is called before the first frame update
    void Start()
    {
        PauseBG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!PauseBG.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                GameState.instance.currentState = GameState.State.Pause;
                PauseBG.SetActive(true);
            }

            else {
                Cursor.lockState = CursorLockMode.Locked;
                GameState.instance.currentState = GameState.State.Play;
                PauseBG.SetActive(false);
            }
        }
    }
}
