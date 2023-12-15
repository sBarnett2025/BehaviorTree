using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTimeSinceShot : BehaviorTreeNode
{
    public override void Start()
    {
        
    }

    public override bool Run()
    {
        if (agent.timeSinceShot > agent.shotRechargeTime)
        {
            return true;
        }

        agent.timeSinceShot += Time.deltaTime;

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
