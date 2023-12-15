using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerSetDestination : BehaviorTreeNode
{
    public override void Start()
    {
        
    }

    public override bool Run()
    {
        agent.moveTo = agent.playerPosition;

        return true;
    }

    public override void Setup()
    {
        if (transform.parent.GetComponent<BehaviorTreeNode>().agent != null)
        {
            agent = transform.parent.GetComponent<BehaviorTreeNode>().agent;
        }
    }
}
