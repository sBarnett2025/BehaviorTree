using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAtDestination : BehaviorTreeNode
{
    public override void Start()
    {
        
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

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }
}
