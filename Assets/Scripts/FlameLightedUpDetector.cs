using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameLightedUpDetector : MonoBehaviour
{
    public GameObject redFlame;
    public bool flameLightUp;

    public GameObject LightUpUIParticle;
    public Canvas LUPCanvas;
    public GameObject lampShower;

    // Start is called before the first frame update
    void Start()
    {
        flameLightUp = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !flameLightUp)
        {
            HintPanelCotroller.instance.CreateHint("Light Candle: Player Detected, auto turn on the light!");

            // get player's animator
            // auto turn on the fire light
            redFlame.GetComponent<Animator>().SetBool("FlameStart", true);
            flameLightUp = true;

            // create the ui particle effect
            CreateUIParticleEffect();
        }
    }

    private void CreateUIParticleEffect()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(redFlame.transform.position);
        GameObject LUParticleObj = Instantiate(LightUpUIParticle, screenPos,
            Quaternion.Euler(Vector3.zero), LUPCanvas.gameObject.transform);

        UIParticleEffectController LUPController = LUParticleObj.GetComponent<UIParticleEffectController>();
        // set lamp shower UI 
        LUPController.lampShower = lampShower;
    }
}
