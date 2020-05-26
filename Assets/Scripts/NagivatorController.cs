using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NagivatorController : MonoBehaviour
{
    public Transform target = null;
    public NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            float dist = agent.remainingDistance;
            if (dist != Mathf.Infinity && 
                agent.pathStatus == NavMeshPathStatus.PathComplete && 
                dist == 0 && 
                !agent.pathPending)
            {
                // self destroy
                Destroy(gameObject);
                target = null;
                Debug.Log("Target reached");
            }
        }
    }

    public void StartNavigation()
    {
        // random one of the candle and start navigation
        int id = 0;
        for(int i=0; i< GameState.instance.flameLightUpList.Length; i++)
        {
            if (!GameState.instance.flameLightUpList[i].flameLightUp)
            {
                id = i;
                break;
            }
        }

        target = GameState.instance.flameLightUpList[id].gameObject.transform.parent.transform;

        // set destination value to find target
        agent.SetDestination(target.position);
    }
}
