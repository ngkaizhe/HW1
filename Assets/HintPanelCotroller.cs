using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintPanelCotroller : MonoBehaviour
{
    public GameObject hintBG;
    public TextMeshProUGUI hintContext;
    public static HintPanelCotroller instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CreateHint(string text)
    {
        hintBG.SetActive(true);
        hintContext.text = "";
        // StartCoroutine(CreateHintContext("Please pressed Key (\"E\") ... to light up the candle!!!"));
        StartCoroutine(CreateHintContext(text));
    }

    private IEnumerator CreateHintContext(string text)
    {
        foreach(char letter in text.ToCharArray())
        {
            hintContext.text += letter;
            yield return null;
        }
        yield return new WaitForSeconds(1);
        hintBG.SetActive(false);
    }

}
