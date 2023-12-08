using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRange : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
    }

    public override bool Run()
    {
        Vector3 playerPos = new Vector3(agent.playerPosition.x, agent.playerPosition.y, agent.playerPosition.z);
        if ((playerPos - agent.transform.position).magnitude < agent.detectionRadius)
        {
            //Debug.Log("Player In Range");
            return true;
        }
        //Debug.Log("Player Not In Range");
        return false;
    }
}
