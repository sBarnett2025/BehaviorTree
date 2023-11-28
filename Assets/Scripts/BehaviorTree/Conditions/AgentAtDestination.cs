using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAtDestination : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
    }

    public override bool Run()
    {
        if (agent.transform.position == agent.moveTo)
        {
            //Debug.Log("Agent At Destination");
            return true;
        }
        //Debug.Log("Agent Not At Destination");
        return false;
    }
}
