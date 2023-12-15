using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRange : BehaviorTreeNode
{
    AgentController controller;
    public override void Start()
    {
        

        controller = transform.root.GetComponent<AgentController>();
    }

    public override bool Run()
    {
        foreach (Agent a in controller.agents)
        {
            Vector3 playerPos = new Vector3(a.playerPosition.x, a.playerPosition.y, a.playerPosition.z);
            if ((playerPos - a.transform.position).magnitude < a.detectionRadius)
            {
                //Debug.Log("Player In Range");
                return true;
            }
        }
        
        //Debug.Log("Player Not In Range");
        return false;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }

}
