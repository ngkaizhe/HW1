using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIParticleEffectController : MonoBehaviour
{
    public GameObject lampShower;

    private Vector3 lampShowerScreenPos;
    // Start is called before the first frame update
    void Start()
    {
        lampShowerScreenPos = lampShower.transform.position;
        StartCoroutine(ParticleStartingEffect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator ParticleStartingEffect()
    {
        
        while (true)
        {
            float dist = Mathf.Sqrt(Mathf.Pow(gameObject.transform.position.x - lampShowerScreenPos.x, 2) +
                Mathf.Pow(gameObject.transform.position.y - lampShowerScreenPos.y, 2));
            if (dist < 10f) break;
           

            Vector3 dir = Vector3.Normalize(lampShowerScreenPos - gameObject.transform.position);
            gameObject.transform.position += dir * 10;
            yield return null;
        }
        lampShower.GetComponent<LampShowerController>().AddFlameLightUp();
        Destroy(gameObject);
    }
}
