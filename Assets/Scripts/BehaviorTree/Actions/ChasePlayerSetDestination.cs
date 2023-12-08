using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerSetDestination : BehaviorTreeNode
{
    public override void Start()
    {
        agent = transform.root.GetComponent<Agent>();
    }

    public override bool Run()
    {
        agent.moveTo = agent.playerPosition;

        return true;
    }
}
