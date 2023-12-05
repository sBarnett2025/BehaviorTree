using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentTimeSinceShot : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
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
}
