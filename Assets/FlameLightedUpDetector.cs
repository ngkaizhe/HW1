using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameLightedUpDetector : MonoBehaviour
{
    public GameObject redFlame;
    public bool flameLightUp;
    
    public Animator RH;
    public GameObject LightUpUIParticle;
    public Canvas LUPCanvas;
    public GameObject lampShower;

    // Start is called before the first frame update
    void Start()
    {
        flameLightUp = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            // get player's animator
            if (GameInput.GetKeyDown(KeyCode.E))
            {
                // set LH and RH's animation
                RH.SetBool("Fire", true);

                // Debug.Log("Player stay in and pressed E");
                redFlame.GetComponent<Animator>().SetBool("FlameStart", true);
                flameLightUp = true;

                CreateUIParticleEffect();
            }
            else if (GameInput.GetKeyUp(KeyCode.E))
            {
                RH.SetBool("Fire", false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            HintPanelCotroller.instance.CreateHint("Please pressed Key (\"E\") ... to light up the candle!!!");
        }
    }

    private void CreateUIParticleEffect()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(redFlame.transform.position);
        GameObject LUParticleObj = Instantiate(LightUpUIParticle, screenPos,
            Quaternion.Euler(Vector3.zero), LUPCanvas.gameObject.transform);

        UIParticleEffectController LUPController = LUParticleObj.GetComponent<UIParticleEffectController>();
        LUPController.lampShower = lampShower;
    }
}
