using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : BehaviorTreeNode
{
    public override bool Run()
    {
        Vector3 destination = agent.moveTo.normalized;
        float distance = (destination - agent.transform.position).magnitude;

        Vector3 distMoved = destination * agent.moveDistance;
        if (distMoved.magnitude > distance)
        {
            agent.transform.position = destination;
        }
        else
        {
            agent.transform.position += distMoved;
        }
        


        return true;
    }
}
