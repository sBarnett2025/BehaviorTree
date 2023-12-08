using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : BehaviorTreeNode
{
    public override bool Run()
    {

        Vector3 destination = agent.moveTo;
        Vector3 direction = (agent.moveTo - agent.transform.position).normalized;
        Vector3 moved = direction * agent.moveDistance * Time.deltaTime;

        agent.transform.position += moved;

        if ((destination - agent.transform.position).magnitude < 0.125)
        {
            agent.transform.position = destination;
        }

        return true;
    }
}
