using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintPanelCotroller : MonoBehaviour
{
    enum HintState
    {
        ShowingHint,
        PressedAnyKeyToSkip,
        ClosedHint,
    };
    public GameObject hintBG;
    public TextMeshProUGUI hintContext;
    public GameObject pressAnyKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            hintBG.SetActive(true);
            hintContext.text = "";
            StartCoroutine(CreateHintContext("Please pressed Key (\"E\") ... to light up the candle!!!"));
        }
         
    }

    private IEnumerator CreateHintContext(string text)
    {
        foreach(char letter in text.ToCharArray())
        {
            hintContext.text += letter;
            yield return null;
        }
        pressAnyKey.SetActive(true);
    }

}
